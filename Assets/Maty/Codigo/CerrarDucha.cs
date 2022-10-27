using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CerrarDucha : MonoBehaviour
{
    public GameObject literCanva;

    public TextMeshProUGUI literText;

    void StopShowering()
    {
        CodigoText.codigoInstance.globeDialogueCanva.SetActive(false);
        CodigoText.codigoInstance.buttonCanva.SetActive(false);
        literCanva.SetActive(true);
        literText.text = "Usaste " + CodigoText.codigoInstance.liters.ToString() + " litros de agua";
    }
}
