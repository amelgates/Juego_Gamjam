using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextoRandom : MonoBehaviour
{
    public string[] randomText;
    public TextMeshProUGUI randomTextObject;
    public TextMeshProUGUI showText;

    public bool showingText;

    public void ShowRandomText()
    {
        RandomText();
        showText = randomTextObject;
    }

    void RandomText()
    {
        int textPos = Random.Range(0, randomText.Length);
        randomTextObject.text = randomText[textPos];
    }
}
