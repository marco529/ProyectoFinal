//Nombre del desarrolador : Marco Antonio Silva Ruiz
//Asignatura: Estructura de datos
//Descripción del uso del código
/* Este Script se utilizarà para crear disparos de caños directos de la computadora
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    [SerializeField] Rigidbody2D proyectil;
    //Arreglo
    [SerializeField]
    Transform[] disparo;
    [SerializeField] float fuerzaDisparo;

   
    

    // Start is called before the first frame update
    void Start()
    {
        //Arreglo que permitirá que 3 cañones generen el mismo código
        disparo = new Transform[transform.childCount];

        for (int i = 0; i < disparo.Length; i++)
        {
            disparo[i] = transform.GetChild(i);
        }

        //(Codigo que se ejcutara, tiempo despues del play antes de disparo, tiempo entre disparo)
        InvokeRepeating("Shoot", 0f,2f) ;
    }

    // Update is called once per frame
    void Shoot()
    {
        //Codigo que dará la orden a cada uno de los elementos del arreglo
        foreach (var d in disparo)
        {
            var proyectilPos = Instantiate(proyectil) as Rigidbody2D;

            proyectilPos.transform.position = d.position;

            proyectilPos.AddForce(d.up * fuerzaDisparo);

        }
    
    }
}
