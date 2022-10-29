using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager audioManagerInstance;

    public AudioMixer mixer;
    public const string MUSIC_KEY = "MusicV";

    private void Awake()
    {
        if (audioManagerInstance == null)
        {
            audioManagerInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        LoadVolume();
    }

    void LoadVolume()
    {
        float musicVolume = PlayerPrefs.GetFloat(MUSIC_KEY, 1f);

        mixer.SetFloat(controlVolumen.MIXER_MUSIC, Mathf.Log10(musicVolume) * 20);
    }
}
