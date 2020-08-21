//Nombre del desarrolador : Marco Antonio Silva Ruiz
//Asignatura: Estructura de datos
//Descripción del uso del código
/* este script se utilizará para generar el control del jugador
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{//Inicio del cuerpo de clase
 //+++área para declarar+++++++++
 // Tipo de dato + nombre de la variable
    Rigidbody2D fisicasRB2d;
    [SerializeField]
    public float FuerzaSaltoPersonaje;

    [SerializeField]
    public float VelocidadPersonaje;

    
    public SpriteRenderer spritePlayer;
    

    //++++++++++++++++++++++++++


    // Start  sirve para inicializar datos,componentes y variables
    //Carga todos los gameobjects,componentes,acciones,valores o eventosal juego.
    void Start()
    {
        //Representa al dueño de script + El componente fisico que se desea agrergar
        //Podemos observar que se le da velocidad y fuerza en el salto al personaje 

        fisicasRB2d = GetComponent<Rigidbody2D>();
        spritePlayer = GetComponent<SpriteRenderer>();
        FuerzaSaltoPersonaje = 50.0f;
        VelocidadPersonaje = 5.0f;
        

       
        
    }

    // Update sirve para utilizar los datos, componentes y variables
    void Update()
    {
        //Se declara que se hará una entrada (Input), utilizo el operador punto para entrar
        //en sus propiedades y elijo una entrada de tecla.
        //Finalmente se elige la tecla que se representara en el mundo real
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
            //variable para utilizar,agregar dureza,
            //dirección en que agrega esa fuerza la magnitud con que aplicará la fuerza
            //colocar el impulso
        {
            fisicasRB2d.AddForce(Vector2.up*FuerzaSaltoPersonaje,ForceMode2D.Impulse );
        }

        //Se utilizará una entrada input.getkey para darle movimiento a izq y derecha del personaje
        if(Input.GetKey(KeyCode.RightArrow))
            // Se está ingresando .velocity, pues es el dato que queremos cambiar, con un nuevo vector
            // Cambiando los valores en (x,y), al ingresad velocity.y
            //estamos indicando que q
        {
            fisicasRB2d.velocity = new Vector2(VelocidadPersonaje,fisicasRB2d.velocity.y);
           
        }

        if (Input.GetKey(KeyCode.LeftArrow))

        {
            fisicasRB2d.velocity = new Vector2(-VelocidadPersonaje, fisicasRB2d.velocity.y);
        }
        
        
        
    }
}//Fin del cuerpo de clase

