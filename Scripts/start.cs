//Nombre del desarrolador : Marco Antonio Silva Ruiz
//Asignatura: Estructura de datos
//Descripción del uso del código
/* Este Script se utilizará para hacer el cambio de escena al presionar el botón de Inicio 
 */





using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    //Este código invoca al Scene Manage y le indica la suma de uno para generar el cambio.
  public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
        
  
}
