using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CodigoText : MonoBehaviour
{
    public TextMeshProUGUI warningText;
    public TextMeshProUGUI timerText;
    public GameObject globeDialogueCanva;

    private int timer;
    private float timerInt;

    void Update()
    {
        timerInt += Time.deltaTime;
        timer = Mathf.RoundToInt(timerInt);
        timerText.text = "Llevas " + timer.ToString() + " minutos en la ducha";
        
        if (timer > 9)
        {
            globeDialogueCanva.SetActive(true);
            warningText.text = "¡Es hora de cortar el agua!";
        }
        if(timer > 14)
        {
            warningText.text = "¡Estas desperdiciando agua!";
        }
        if (timer > 24)
        {
            warningText.text = "¡Te saldra cara la cuenta del agua!";
        }
        if (timer > 29)
        {
            SceneManager.LoadSceneAsync("Minijuego Ducha");
        }
    }
}
