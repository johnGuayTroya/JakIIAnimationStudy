using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MovimientosPlayer : MonoBehaviour
{

    [Header("recursos")]
    public Camera cam;
    public Vector2 movimiento;
    public Transform player;
    public BoxCollider boxC;
    public SkinnedMeshRenderer[] misMesh;
    public Rigidbody miRigid;
    [Header("variablesGameplay")]
    public float disRayo = 2f;
    public float fuerzaSalto = 2f;
    public float fuerzaPuño = 1f;
    private Vector3 dir;
    //
    [Header("estados PLayer")]
    public bool agacho = false;
    public bool saltar = false;
    public bool giro = false;
    public bool puñetazo = false;

    public bool estoySuelo = true;

    //------------------------------------
    private Animator miAnimator;
    private Animator naveAnimator;
    PS4Control psControl;

    MovimientosNave movNave;
    CameraPlayer camPlayer;

    //-----------------------------------------------
    [Header("varsMovimiento/MovNAve")]
    public float walkSpeed = 2;
    public float runSpeed = 6;
    public float naveSpeed = 0.02f;
    public float naveMaxSpeed = 20f;

    public float turnSmoothTime = 0.2f;
    float turnSmoothVelocity;

    public float speedSmoothTime = 0.1f;

    public float currentSpeed;
    private float InitialSpeed = 0f;
    float speedSmoothVelocity;
  

    public Transform cameraT;


    private void OnEnable()
    {
        psControl.Movimientos.Enable();
    }
    private void OnDisable()


    {
        psControl.Movimientos.Disable();
    }
    private void Awake()

        //Seguir probando con la colision rigid body,box collider casi funciona
    {
        InitialSpeed = runSpeed;
        camPlayer = FindObjectOfType<CameraPlayer>();
        movNave = FindObjectOfType<MovimientosNave>();
        boxC = GetComponent<BoxCollider>();

        miAnimator = GetComponentInParent<Animator>();

        naveAnimator = movNave.GetComponent<Animator>();
        //----------------------------------------------------------
        psControl = new PS4Control();


        //Agacharse
        psControl.Movimientos.agachar.performed += ctx => agacho = true;
        psControl.Movimientos.agachar.canceled += ctx => agacho = false;
        //SAlto
        psControl.Movimientos.saltar.performed += ctx => saltar = true;
        psControl.Movimientos.saltar.canceled += ctx => saltar = false;
        //Giro
        psControl.Movimientos.Spin.started += ctx => giro = true;
        psControl.Movimientos.Spin.canceled += ctx => giro = false;


        //Puñetazo
        psControl.Movimientos.puñetazo.started += ctx => puñetazo = true;
        psControl.Movimientos.puñetazo.canceled += ctx => puñetazo = false;

        //Movimiento
        psControl.Movimientos.Caminar.performed += ctx => movimiento = ctx.ReadValue<Vector2>();
        psControl.Movimientos.Caminar.canceled += ctx => movimiento = Vector2.zero;


        //Gestion de escena
        psControl.Movimientos.reiniciarApp.started += ctx => Application.LoadLevel(0);
        //psControl.Movimientos.reiniciarApp.canceled += ctx => ;

        psControl.Movimientos.salirApp.started += ctx => Application.Quit();

    }
    

    private void Update()
    {
        ColisionRay();
        if (movNave.estoySubido == false)
        {
            MovimientoJugador(player);
            if (giro) {
                
                miAnimator.SetBool("giro", true);
             
            }
            if (puñetazo) {

                miAnimator.SetBool("puñetazo", true);
                player.transform.position += Vector3.forward * fuerzaPuño * Time.deltaTime;

                //cam.transform.forward * fuerzaPuño*Time.deltaTime;
               
                
            }
        }
        else
        {
            miAnimator.SetBool("idle", true);
            miAnimator.SetBool("camina", false);
            miAnimator.SetBool("corre", false);
            MovimientoJugador(movNave.transform);
            
        }

       

        if (estoySuelo)
        {
            if (saltar && movNave.bajo==false)
            {
               
                miAnimator.SetBool("saltar", true);
                miAnimator.SetBool("camina", false);
                estoySuelo = false;
                saltar = false;
                player.transform.position += Vector3.up * fuerzaSalto;
                boxC.transform.position += Vector3.up * fuerzaSalto * 2;

            }
        }

       
    }

    private void ColisionRay()
    {

        RaycastHit hit;
        dir = new Vector3(0, -1, 0);
        var disSuelo = 0f;
        Debug.DrawRay(transform.position, dir * disRayo, Color.green);


        if (Physics.Raycast(transform.position, dir, out hit, disRayo))
        {
            if (hit.collider.tag == "suelo") { disSuelo = hit.distance; }
            //print("Distancia al suelo Ini" + disSuelo);
            //print("Distancia la suelo" + hit.distance);
            if (movNave.estoySubido == false && hit.distance >= fuerzaSalto && hit.collider.tag == "suelo")  //estaba en 3.7
            {
                miRigid.isKinematic = false;
                estoySuelo = false;

            }
            else if (hit.distance <= 0.0666f && hit.collider.tag == "suelo")
            {

                miRigid.isKinematic = true;
                estoySuelo = true;
                miAnimator.SetBool("saltar", false);
                

            }

        }

    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "suelo")
    //    {

    //        estoySuelo = true;
    //        miAnimator.SetBool("saltar", false);
    //    }
    //    else { estoySuelo = false; }
    //}


    private void MovimientoJugador(Transform mov)
    {
        miAnimator.SetBool("giro", false);
        miAnimator.SetBool("puñetazo", false);

        Vector2 input = new Vector2(0, movimiento.y);
        Vector2 inputDir = input.normalized;

        //print("Movmiento y" + movimiento.y);

        if (inputDir != Vector2.zero)
        {
            float targetRotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg + cameraT.eulerAngles.y;
            mov.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(mov.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);
        }
        
        bool running = false;
        if (movimiento.y >= 0.5 && movNave.estoySubido == true)
        {

            running = true;

            while (runSpeed <= naveMaxSpeed)
            {
                runSpeed += naveSpeed;
            }
            runSpeed += naveSpeed;
        }
        else {
            running = true;
            while (runSpeed > InitialSpeed)
            {
               
                //if (movimiento.y >= 0.5 && movNave.estoySubido == true) { break; }
                runSpeed--;
            }
          
        }

        if (movimiento.y >= 0.5 && movNave.estoySubido == false) { running = true; }


      

        float targetSpeed = ((running) ? runSpeed : walkSpeed) * inputDir.magnitude;
        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothVelocity, speedSmoothTime);



        
        mov.Translate(mov.forward * currentSpeed * Time.deltaTime, Space.World);
        print("Current Speed" + currentSpeed);
        
        if(movNave.estoySubido == false)
        {

            if (movimiento.y == 0)
            {
                miAnimator.SetBool("idle", true);
                miAnimator.SetBool("camina", false);
                miAnimator.SetBool("corre", false);

                if (agacho == true)
                {
                    miAnimator.SetBool("agacharse", true);
                    miAnimator.SetBool("idle", false);
                }
                else { miAnimator.SetBool("agacharse", false); }

            }

            if (currentSpeed >= 1 ) //camina
            {
                miAnimator.SetBool("camina", true);
                miAnimator.SetBool("corre", false);
                miAnimator.SetBool("idle", false);

            }

            //if (currentSpeed >= 5)
            //{
            //    miAnimator.SetBool("corre", true);
            //    miAnimator.SetBool("camina", false);
            //    miAnimator.SetBool("idle", false);
            //}

            
        }


        if (movNave.estoySubido == true)
        {
            print("enZOOMER");
            if (camPlayer.giroCam == Vector2.zero && movimiento.y==0)  //quieto
            {
                naveAnimator.SetBool("idleZoomer", true);
                naveAnimator.SetBool("giroIzq", false);
                naveAnimator.SetBool("giroDecha", false);
                naveAnimator.SetBool("acelZoomer", false);
            }
            if (camPlayer.giroCam==Vector2.zero &&  movimiento.y >= 0.5) //acelera
            {
                naveAnimator.SetBool("acelZoomer", true);
                naveAnimator.SetBool("giroIzq", false);
                naveAnimator.SetBool("giroDecha", false);
                naveAnimator.SetBool("idleZoomer", false);
            }
            if ( camPlayer.giroCam.x >= 0.3) {  //giro decha

                naveAnimator.SetBool("giroDecha",true);
                naveAnimator.SetBool("giroIzq", false);
            }
           
            if (camPlayer.giroCam.x<=-0.3) //giroIZq
            {
                naveAnimator.SetBool("giroIzq", true);
                naveAnimator.SetBool("giroDecha", false);
            }

        }
        else { print("enNoZOOMER"); }
      
    }

   

}
