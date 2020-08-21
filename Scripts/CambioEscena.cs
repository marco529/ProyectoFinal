//Nombre del desarrolador : Marco Antonio Silva Ruiz
//Asignatura: Estructura de datos
//Descripción del uso del código
/* Este Script se utilizará para generar un cambio de escena en un proyecto 2D
 */




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    //Esta variable almacenará el numero de escena a cargar
    [Tooltip("Esta variable me ayuda a definir el número de escena a cargar")]
    public int numeroEscena;



    //Este indica el cambio de escena al momento de la colision con el objeto que contenga el código
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(numeroEscena);
        }
    }

}
