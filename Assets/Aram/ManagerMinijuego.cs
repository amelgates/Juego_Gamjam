using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ManagerMinijuego : MonoBehaviour
{
    public float puntaje;
    public TextMeshProUGUI texto;
    public GameObject[] basuras;
    int randomInt;
    public Transform spawnTransform;

    public float spawnDelay;
    public bool juegoTerminado;
    public GameObject canvas1;
    public GameObject canvas2;

    private void Update()
    {
        ActualizarPuntaje();

         spawnDelay = spawnDelay - 1 * Time.deltaTime;
        if(!juegoTerminado)
        {
            if (spawnDelay <= 0)
            {
                SpawnItems();

            }


            if (puntaje >= 10)
            {
                FinDelJuego();
            }
        }
    }

    public void FinDelJuego()
    {
        juegoTerminado = true;
        canvas1.SetActive(false);
        canvas2.SetActive(true);

    }

    public void ActualizarPuntaje()
    {
        texto.text = puntaje.ToString();

        if (puntaje <= 0)
        {
            puntaje = 0;
        }
    }

    public void SpawnItems()
    {
        randomInt = Random.Range(0, basuras.Length);
        Instantiate(basuras[randomInt], spawnTransform.position, spawnTransform.rotation);
        spawnDelay = 2;
    }

    public void ResetPuntaje()
    {
        puntaje = 0;
    }
}
