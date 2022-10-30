using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CodigoText : MonoBehaviour
{
    public static CodigoText codigoInstance; 

    public TextMeshProUGUI warningText;
    public TextMeshProUGUI timerText;
    public GameObject globeDialogueCanva;
    public GameObject timerCanva;

    public int liters;
    public int timer;
    public bool timerRun = true;
    public float timerFloat;

    private void Awake()
    {
        codigoInstance = this;
    }
    void Update()
    {
        Timer();
        timerText.text = "Llevas " + timer.ToString() + " minutos en la ducha";

        if (timer == 5)
        {
            globeDialogueCanva.SetActive(true);
            warningText.text = "¡Es hora de cortar el agua!";
            liters = 50;
        }
        if(timer > 9)
        {
            warningText.text = "¡Estas desperdiciando agua!";
            liters = 100;
        }
        if (timer > 14)
        {
            warningText.text = "¡Te saldra cara la cuenta del agua!";
            liters = 150;
        }
        if (timer == 20)
        {
            liters = 200;
            timerRun = false;
        }
    }
    public void Timer()
    {
        if(timerRun == true)
        {
        timerFloat += Time.deltaTime;
        timer = Mathf.RoundToInt(timerFloat);
        }

    }

    public void ResetTimer()
    {
        timerRun = true;
        timer = 0;
        liters = 0;
        timerFloat = 0;
    }
}
