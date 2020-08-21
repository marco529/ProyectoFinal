//Nombre del desarrolador : Marco Antonio Silva Ruiz
//Asignatura: Estructura de datos
//Descripción del uso del código
/* Este Script se utilizarà para generar movmimento de camara
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    //Estas variables se toman como el objetivo a seguir y el punto incial de la camara
    public Transform target;
    public Vector3 puntoInicial;

    // Start is called before the first frame update
    void Start()
    {
        //puntoinicial= transform.postion

        //Este codigo mantendrá forzozamente el espacio entre el jugador y la cámara
        puntoInicial = transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        //Libreria que delimita minimos y maximos de un objeto, es utilizado para crear la delimitacion del 
        //Movimiento de Camara


        transform.position = new Vector3(Mathf.Clamp(target.position.x,-0.51f,72.2f), transform.position.y, transform.position.z); 


    }
}
