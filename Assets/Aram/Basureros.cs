using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basureros : MonoBehaviour
{
    public string basuraCorrecta;
    public ManagerMinijuego mg;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(basuraCorrecta))
        {
            print("Correcto");
       
            mg.puntaje += 1;

        }

        if(!collision.CompareTag(basuraCorrecta))
        {
            print("Incorrecto");
             mg.puntaje -= 1;

        }
    }

}
