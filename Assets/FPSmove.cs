using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSmove : MonoBehaviour
{   
    public float speed = 0.1f; // Se ingresa la velocidad a la cuál se moverá el objeto. 
    void Start()
    {

    }
    void Update()

    /*
    
    En este bloque de código se asignan los movimientos de la forma WASD al teclado. De la siguiente forma: W: adelante, A: izquierda, S: atrás, D: derecha. 

     */
    {
        if (Input.GetKey (KeyCode.W))
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }
    }
}