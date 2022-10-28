using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume (float v)
    {
        audioMixer.SetFloat("volume", v);
    }
    public void NextScene()
    {
        SceneManager.LoadScene("Juego");
    }

    public void EndProgram()
    {
        Application.Quit();
    }
}
