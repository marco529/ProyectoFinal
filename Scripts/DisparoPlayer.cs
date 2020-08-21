//Nombre del desarrolador : Marco Antonio Silva Ruiz
//Asignatura: Estructura de datos
//Descripción del uso del código
/* Este Script se utilizará para generar un cambio de escena en un proyecto 2D
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPlayer : MonoBehaviour
{
    //Zona de Declaracion de variables
    [SerializeField] Rigidbody2D proyectil;
    [SerializeField] Transform  ManoD;
    [SerializeField] Transform ManoI;
    [SerializeField] float fuerzaDisparo;
    [SerializeField] KeyCode teclaDisparoD;
    [SerializeField] KeyCode teclaDisparoI;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        //Codigo de Fuerza de Disparo


        if (Input.GetKeyDown(teclaDisparoD))
        {
            var proyectilPos = Instantiate(proyectil) as Rigidbody2D;

            proyectilPos.transform.position = ManoD.position;

            proyectilPos.AddForce(ManoD.right * fuerzaDisparo);
        }

        if (Input.GetKeyDown(teclaDisparoI))
        {
            var proyectilPos = Instantiate(proyectil) as Rigidbody2D;

            proyectilPos.transform.position = ManoI.position;

            proyectilPos.AddForce(ManoI.right * -fuerzaDisparo);
        }

       

    }

  
}
