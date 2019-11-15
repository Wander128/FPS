using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour
{
    
    float mouseX; // Variable para la posición en X
    float mouseY; // Variable para la posición en Y
    public bool InvertedMouse; // CheckBox usado para invertir la cámara
    public GameObject player; // Se crea para ingresarle el movimiento a la cámara.
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Función ingresada para evitar la aparicón del cursor en pantalla.
    }

    
    void Update()
    /*
    Bloque de código en el cuál se le dan las órdenes de movimiento en eje X y Y, además se indican las acciones a realizar cuando se activa el CheckBox. 
    El Debug lo usamos para imprimir los movimientos de X.
    */
    {
        mouseX += Input.GetAxis("Mouse X");
        if (InvertedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");
        } else

        {
            mouseY -= Input.GetAxis("Mouse Y");
        }

        Debug.Log(mouseX);

        transform.eulerAngles = new Vector3(mouseY,mouseX ,0);
        player.transform.eulerAngles = new Vector3(0,mouseX ,0);
    /*
    Las opciones anteriores se ingresan para asignar valores en relación al movimiento y el objeto. 
     */
    }  
         
}
    
