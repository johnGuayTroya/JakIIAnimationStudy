using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
  
    public Vector2 giroCam;

    PS4Control psControl;

    //-----------------------------------

    public float arregloCam = 3f;
    public float sensibilidad = 10;
    public Transform target;
    public float dstFromTarget = 2;
    public Vector2 pitchMinMax = new Vector2(-40, 85);

    public float rotationSmoothTime = .12f;
    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;

    float yaw;
    float pitch;
    private void OnEnable()
    {
        psControl.camara.Enable();
    }
    private void OnDisable()


    {
        psControl.camara.Disable();
    }
    private void Awake()
    {
        psControl = new PS4Control();

        psControl.camara.Giro.performed += ctx => giroCam = ctx.ReadValue<Vector2>();

        psControl.camara.Giro.canceled += ctx => giroCam = Vector2.zero;
    }

    void LateUpdate()
    {
        //print("giro x ="+ giroCam.x);
        //print("giro y =" + giroCam.y);

        yaw += giroCam.x * sensibilidad;
        pitch -= 0 * sensibilidad;
        pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);
        transform.eulerAngles = currentRotation;

      
        transform.position = target.position - transform.forward * dstFromTarget;
        transform.position = transform.position + Vector3.up * arregloCam;


    }



}
