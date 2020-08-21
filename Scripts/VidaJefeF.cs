//Nombre del desarrolador : Marco Antonio Silva Ruiz
//Asignatura: Estructura de datos
//Descripción del uso del código
/* Este Script se utilizará para llevar la cuenta de la vida del jefe final
 */




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaJefeF : MonoBehaviour
{
    //Variables que indican la vida del enemigo.
    public int enemyHealth = 10;
    public Image barradeVida;

    //Se hace referencia a fill amount utilizando la libreria UnityEngine.
    //Con esta se puede reducir el relleno de una imagen, lo que generará la idea de la barra de vida en el juego
    private void Start()
    {
        barradeVida.fillAmount= 1;
    }

    //Las siguientes lineas nos indican como irá disminuyendo la vida del Jefe con las diferentes colisiones

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bala")
        {
            Debug.Log(enemyHealth);
            GetComponent<SpriteRenderer>().color = Color.grey;
            enemyHealth = enemyHealth - 1;
            barradeVida.fillAmount -= 0.10f;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
        if (enemyHealth == 0)
        {
            Destroy(gameObject);
        }

    }
}
