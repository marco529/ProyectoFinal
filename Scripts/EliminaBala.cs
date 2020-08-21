//Nombre del desarrolador : Marco Antonio Silva Ruiz
//Asignatura: Estructura de datos
//Descripción del uso del código
/* Este Script se utilizará para generar la destrucción de todas las balas del juego
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminaBala : MonoBehaviour
{
    public float vidaBala;

    //Las siguientes lineas de código indican la destrucción de la bala al colisionar con un enemigo.
    //De lo contrario la bala se destruye un segundo después de ser lanzada.
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "enemigo")
        {
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        Destroy(gameObject, vidaBala);
    }
}
