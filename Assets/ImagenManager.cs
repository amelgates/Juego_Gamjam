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
    public GameObject instrucPanel;
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
            pieza.SetActive(false);
        }
        if(basuraReady)
        {
            botonDucha.SetActive(false);
            botonInstruc.SetActive(false);
            botonNota.SetActive(false);
            dialogoBasura2.SetActive(true);
            botonBasura.SetActive(false);
        }
        else
        {
            botonDucha.SetActive(false);
            botonInstruc.SetActive(false);
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
        if (contadorImagen == 2)
        {
            imagen2.SetActive(true);
        }
        if (contadorImagen == 3)
        {
            imagen3.SetActive(true);
        }
        if (contadorImagen == 4)
        {
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
}
