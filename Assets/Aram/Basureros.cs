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
            mg.puntaje += 1;
        }

        if(!collision.CompareTag(basuraCorrecta))
        {
             mg.puntaje -= 1;
        
        }
    }

}
