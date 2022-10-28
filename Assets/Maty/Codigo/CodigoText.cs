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

    public int liters;
    public int timer;
    public float timerFloat;

    private void Awake()
    {
        codigoInstance = this;
    }
    void Update()
    {
        Timer();
        timerText.text = "Llevas " + timer.ToString() + " minutos en la ducha";

        if (timer == 10)
        {
            globeDialogueCanva.SetActive(true);
            warningText.text = "¡Es hora de cortar el agua!";
            liters = 100;
        }
        if(timer > 14)
        {
            warningText.text = "¡Estas desperdiciando agua!";
            liters = 150;
        }
        if (timer > 19)
        {
            warningText.text = "¡Te saldra cara la cuenta del agua!";
            liters = 200;
        }
        if (timer >=24)
        {
            liters = 250;
        }
    }
    void Timer()
    {
        timerFloat += Time.deltaTime;
        timer = Mathf.RoundToInt(timerFloat);
    }
}
