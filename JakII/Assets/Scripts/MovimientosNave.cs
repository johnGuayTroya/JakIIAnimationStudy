using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MovimientosNave : MonoBehaviour
{
    
    [Header("vars")]
    public Transform jugador;
    public Transform ladoIzqNave;
    public float disEntroNaveLadoIzq = 8f;

    public bool subo = false;
    public bool bajo = false;

    public bool estoySubido = false;
    //Activo las mesh JAD de la animacion de la nave
    public SkinnedMeshRenderer[] meshNave;

     
    Animator myNaveAnim;
    public Animator jugadorAnim;

    //
    private MovimientosPlayer mPlayer;
    private CameraPlayer camP;

    PS4Control psControl;
    private void OnEnable()
    {
        psControl.Movimientos.Enable();
    }
    private void OnDisable()


    {
        psControl.Movimientos.Disable();
    }
    private void Awake()
    {
        psControl = new PS4Control();

        psControl.Movimientos.subirNave.started += ctx => subo = true;
        psControl.Movimientos.saltar.started += ctx => bajo = true;
        //psControl.Movimientos.subirNave.canceled += ctx => subo = false;
    }
    void Start()
    {
       
        camP = FindObjectOfType<CameraPlayer>();
        mPlayer = FindObjectOfType<MovimientosPlayer>();
        meshNave = GetComponentsInChildren<SkinnedMeshRenderer>();
        myNaveAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var distance = jugador.position - ladoIzqNave.position;
        //Debug.Log(distance.sqrMagnitude);

        
        if (distance.sqrMagnitude < disEntroNaveLadoIzq)
        {
        
            //Debug.Log("puedoSUbir");
            if (subo == true)
            {

                
                camP.target = transform;
                camP.dstFromTarget = 12.11f;   /* 7.8f;  cuando pongo el arreglo de la cam*/
                camP.sensibilidad = 2;
                camP.rotationSmoothTime = 0.30f;

                estoySubido = true;
                subo = false;
                myNaveAnim.SetBool("entraZoomer", true);
                jugadorAnim.SetBool("entraZoomer", true);
                mPlayer.speedSmoothTime = 2;

                jugador.parent = this.transform;
                jugador.transform.position = new Vector3(0, 0, 0);

                //uso una corrutina con la duracion de esta animacion y desactico/activo
                //desactivo y acitvo las meshes
                StartCoroutine(EntroZoomer());

            }

        }
        else { subo = false;  }

        if (estoySubido==true && bajo == true)
        {
            
            StartCoroutine(SalgoZoomer());
            estoySubido = false;
        }
        else { bajo = false; }

    }

   IEnumerator EntroZoomer()
    {
        yield return new WaitForSeconds(0.3f);
        
        mPlayer.misMesh[0].enabled = false;
        mPlayer.misMesh[1].enabled = false;
        meshNave[0].enabled = true;
        meshNave[1].enabled = true;
        //Cambio a idle anmation del player
        
    }

    IEnumerator SalgoZoomer()
    {
        
        mPlayer.currentSpeed = 0;
        mPlayer.estoySuelo = false;
        bajo = false;

        myNaveAnim.SetBool("salirZoomer", true);
        
        jugadorAnim.SetBool("entraZoomer", false);
        jugadorAnim.SetBool("saltar", false);
        yield return new WaitForSeconds(1.44f);
        myNaveAnim.SetBool("salirZoomer", false);
        myNaveAnim.SetBool("entraZoomer", false);

        mPlayer.misMesh[0].enabled = true;
        mPlayer.misMesh[1].enabled = true;
        meshNave[0].enabled = false;
        meshNave[1].enabled = false;

        jugador.parent = null;
        jugador.position = transform.position+ new Vector3(0,3.7f,-0.30f);
        
        camP.target = jugador;
        camP.sensibilidad = 3;
        camP.rotationSmoothTime = 0.75f;
        mPlayer.speedSmoothTime = 0.2f;
            

    }
}
