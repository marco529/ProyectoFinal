//Nombre del desarrolador : Marco Antonio Silva Ruiz
//Asignatura: Estructura de datos
//Descripción del uso del código
/* Este Script se utilizará para llevar la vida de los enemigos y las acciones que ocurren al colisionar
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{ 
    //El enemigo cuenta con 3 puntos de vida
    public int enemyHealth = 3;

    //Indicando la colsion con la bala del personaje y su cambio de color a gris para indicar el daño
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bala")
        {
            
            GetComponent<SpriteRenderer>().color = Color.grey;
            enemyHealth = enemyHealth - 1;

        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }

        //Marca la destrucción total del enemigo cuando su vida llega a 0
        if (enemyHealth == 0)
        {
            Destroy(gameObject);
        }

    }

    
}

