//Nombre del desarrolador : Marco Antonio Silva Ruiz
//Asignatura: Estructura de datos
//Descripción del uso del código
/* Este Script se utilizará para generar un cambio de escena en un proyecto 2D
 */





using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPersonaje : MonoBehaviour
{
    static int vida;
    public int daño;
    //float curvida;
    Rigidbody2D pBR;
    public float BumpX, BumpY;
    public Image barradeVida;


    // Start is called before the first frame update
    void Start()
    {
        vida = 5;
        daño = 1;
        pBR = GetComponent<Rigidbody2D>();
        
        //Se hace referencia a fill amount utilizando la libreria UnityEngine.
        //Con esta se puede reducir el relleno de una imagen, lo que generará la idea de la barra de vida en el juego

        barradeVida.fillAmount = 1;
    }

  
     

private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "BalaEnemiga")
        {
            vida = vida - daño;
            barradeVida.fillAmount -= 0.20f;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

    //Las siguientes lineas nos muestran las reaciiones del jugador hacia las colisiones marcadas.
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BalaEnemiga")
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemigo")
        {
            vida= vida - daño;
            barradeVida.fillAmount -= 0.20f;

             GetComponent<SpriteRenderer>().color = Color.red;

           
           


            if (collision.GetComponent<SpriteRenderer>().flipX== false)
            {
                pBR.velocity = new Vector2(-BumpX,BumpY);

            }
           else if (collision.GetComponent<SpriteRenderer>().flipX == true)
            {
                pBR.velocity = new Vector2(-BumpX, BumpY);
            }

            if(collision.tag =="CambioEscena")
            {
                vida = 5;
                barradeVida.fillAmount = 1;
            }

          
        }
      

   

    }
    //Las siguientes lineas guian al código a regresar al color natural del jugador si no existe colison con los tags señalados
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "enemigo")
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
       
    }

    private void Update()
    {
        if (vida == 0)

        {
            Destroy(this.gameObject);
        }
    }

}
