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

    private float progressFloat;

    private void Awake()
    {
        cerrarDuchaInstace = this;
    }
    private void Update()
    {
        sliderProgress.value = progressFloat;

        if (Input.GetMouseButton(0))
        {
            progressFloat += Time.deltaTime;
        }

        if (CodigoText.codigoInstance.timer >= 5)
        {
            sliderCanva.SetActive(true);
        }

        if(sliderProgress.value == 5 | CodigoText.codigoInstance.timer >= 20)
        {
            showLitersCanva();
            CodigoText.codigoInstance.timerRun = false;
        }
    }
    void showLitersCanva()
    {
        CodigoText.codigoInstance.globeDialogueCanva.SetActive(false);
        sliderCanva.SetActive(false);
        literCanva.SetActive(true);
        literText.text = "Utilizaste " + CodigoText.codigoInstance.liters.ToString() + " litros";
    }
}
