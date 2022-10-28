using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImagenManager : MonoBehaviour
{
    public float contadorImagen = 1;
    public bool basuraReady;
    public bool duchaReady;
    public GameObject canvas;
    public void NextImagen()
    {
        if (contadorImagen == 4)
        {
            SceneManager.LoadScene("MenuInicio");
        }
        else
        {
            contadorImagen += 1;
            canvas.SetActive(false);
        }
    }

    public void BasuraLista()
    {
        basuraReady = true;
    }

    public void DuchaLista()
    {
        duchaReady = true;
    }

    public void ResetBools()
    {
        basuraReady = false;
        duchaReady = false;
    }
}
