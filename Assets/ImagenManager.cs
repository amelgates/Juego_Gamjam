using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImagenManager : MonoBehaviour
{
    public float contadorImagen = 1;
    public float contadorVecino = 1;
    public bool basuraReady;
    public bool postitReady;
    public bool instruccionesReady;
    public GameObject canvasImagenes;
    public GameObject postitPanel;
    public GameObject botonesEmpty;
    public GameObject basuraMinigame;
    public GameObject pieza;
    public GameObject dialogoNoBasura;
    public GameObject botonBasura;
    public GameObject botonNota;
    public GameObject botonInstruc;
    public GameObject botonDucha;
    public GameObject botonTele;
    public GameObject instrucPanel;
    public GameObject imagen1;
    public GameObject imagen2;
    public GameObject imagen3;
    public GameObject imagen4;
    public GameObject duchaMinigame;
    public GameObject vecinosEspacio;
    public GameObject punki;
    public GameObject abuela;
    public GameObject empresario;
    public GameObject duchaDialogo;
    public GameObject dialogoBasura2;
    public GameObject duchaTiempo;
    public GameObject duchaDialogoCanva;
    public GameObject duchaProgreso;
    public GameObject duchaLitros;
    public GameObject duchaControl;
    public GameObject basuraBasureros;
    public GameObject basuraManager;
    public GameObject basuraCanvas1;
    public GameObject basuraCanvas2;

    public void Awake()
    {
        contadorImagen = 1;
        contadorVecino = 1;
        basuraReady = false;
        postitReady = false;
        instruccionesReady = false;
    }
    public void NextImagen()
    {
        if (contadorImagen == 4)
        {
            SceneManager.LoadScene("MenuInicio");
        }
        else
        {
            contadorImagen += 1;
            botonesEmpty.SetActive(true);
            canvasImagenes.SetActive(false);
        }
    }

    public void BotonPostit()
    {
        postitPanel.SetActive(true);
        botonesEmpty.SetActive(false);
        postitReady = true;
    }

    public void BasuraBoton()
    {
        if (instruccionesReady)
        {
            basuraMinigame.SetActive(true);
            basuraCanvas1.SetActive(true);
            basuraCanvas2.SetActive(false);
            pieza.SetActive(false);
        }
        if(basuraReady)
        {
            botonDucha.SetActive(false);
            botonTele.SetActive(false);
            botonInstruc.SetActive(false);
            botonNota.SetActive(false);
            dialogoBasura2.SetActive(true);
            botonBasura.SetActive(false);
        }
        else
        {
            botonDucha.SetActive(false);
            botonInstruc.SetActive(false);
            botonTele.SetActive(false);
            botonNota.SetActive(false);
            dialogoNoBasura.SetActive(true);
            botonBasura.SetActive(false);
        }
    }

    public void DuchaFinish()
    {
        pieza.SetActive(true);
        botonesEmpty.SetActive(false);
        duchaMinigame.SetActive(false);
        duchaLitros.SetActive(false);

        if (contadorImagen == 2)
        {
            canvasImagenes.SetActive(true);
            imagen1.SetActive(false);
            imagen2.SetActive(true);
        }
        if (contadorImagen == 3)
        {
            canvasImagenes.SetActive(true);
            imagen2.SetActive(false);
            imagen3.SetActive(true);
        }
        if (contadorImagen == 4)
        {
            canvasImagenes.SetActive(true);
            imagen3.SetActive(false);
            imagen4.SetActive(true);
        }
    }

    public void DuchaBoton()
    {
        if (basuraReady)
        {
            pieza.SetActive(false);
            duchaMinigame.SetActive(true);
            duchaTiempo.SetActive(true);
            duchaDialogo.SetActive(false);
            duchaProgreso.SetActive(false);
            duchaLitros.SetActive(false);
            duchaControl.SetActive(true);
        }
        else
        {
            botonBasura.SetActive(false);
            botonDucha.SetActive(false);
            botonInstruc.SetActive(false);
            botonNota.SetActive(false);
            botonTele.SetActive(false);
            duchaDialogo.SetActive(true);
        }
    }

    public void InstrucBoton()
    {
        instrucPanel.SetActive(true);
        botonesEmpty.SetActive(false);
        instruccionesReady = true;
    }

    public void ResetBools()
    {
        basuraReady = false;
    }

    public void VecinoFinal()
    {
        contadorVecino += 1;
        pieza.SetActive(true);
        vecinosEspacio.SetActive(false);
    }

    public void BasuraFinish()
    {
        basuraReady = true;
        basuraMinigame.SetActive(false);
        vecinosEspacio.SetActive(true);
        if (contadorVecino == 1)
        {
            abuela.SetActive(false);
            empresario.SetActive(false);
            punki.SetActive(true);
        }
        if(contadorVecino == 2)
        {
            punki.SetActive(false);
            empresario.SetActive(false);
            abuela.SetActive(true);
        }
        if(contadorVecino == 3)
        {
            abuela.SetActive(false);
            punki.SetActive(false);
            empresario.SetActive(false);
        }
    }
}
