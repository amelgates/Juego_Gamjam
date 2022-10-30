using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CerrarDucha : MonoBehaviour
{
    public static CerrarDucha cerrarDuchaInstace;

    public GameObject literCanva;
    public GameObject sliderCanva;
    public TextMeshProUGUI literText;
    public Slider sliderProgress;

    public float progressFloat;

    public bool funcionando;
    private void Awake()
    {
        cerrarDuchaInstace = this;
    }
    private void Update()
    {
        if(funcionando)
        {
            sliderProgress.value = progressFloat;

            if (Input.GetMouseButton(0) && sliderProgress.IsActive())
            {
                progressFloat += Time.deltaTime;
            }

            if (CodigoText.codigoInstance.timer >= 5)
            {
                sliderCanva.SetActive(true);
            }

            if (sliderProgress.value == 2 | CodigoText.codigoInstance.timer >= 20)
            {
                CodigoText.codigoInstance.timerRun = false;
                showLitersCanva();
            }
        }
    }
    void showLitersCanva()
    {
        funcionando = false;
        CodigoText.codigoInstance.globeDialogueCanva.SetActive(false);
        sliderCanva.SetActive(false);
        literCanva.SetActive(true);
        literText.text = "Utilizaste " + CodigoText.codigoInstance.liters.ToString() + " litros";
    }

    public void ResetSlider()
    {
        sliderProgress.value = 0;
        progressFloat = 0;
        funcionando = true;
    }
}
