using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuManager : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Juego");
    }

    public void EndProgram()
    {
        Application.Quit();
    }
}
