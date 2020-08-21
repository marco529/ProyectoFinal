//Nombre del desarrolador : Marco Antonio Silva Ruiz
//Asignatura: Estructura de datos
//Descripción del uso del código
/* Este Script se utilizarà para generar movmimento de horizontal de los enemigos
 */






using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePatrol : MonoBehaviour
{
    //Se generan variables públicas en las cuales se pueden ingresar los puntos de inicio y fin
    //Además de la velocidad del enemigo
    public GameObject startPoint;
    public GameObject endPoint;

    public float enemySpeed;

    private bool goRight;
    
    // Start is called before the first frame update
    void Start()
    {
        //Estas lineas permiten el inicio del movimiento 
        if(goRight   )
        {
            transform.position = startPoint.transform.position;
        }
        else
        {
            transform.position = endPoint.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Las siguientes lineas marcan el retorno del personaje generando un loop hasta su destrucción

        if(goRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.transform.position, enemySpeed* Time.deltaTime );
            if(transform.position== endPoint.transform.position)
            goRight = false;
        }
        if (!goRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPoint.transform.position, enemySpeed * Time.deltaTime);
            if(transform.position== startPoint.transform.position)
            goRight = true;
        }
    }
}
