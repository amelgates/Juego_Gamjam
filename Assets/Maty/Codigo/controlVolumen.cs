using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class controlVolumen : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider sliderMusic;

    public const string MIXER_MUSIC = "MusicV";

    private void Awake()
    {
        sliderMusic.onValueChanged.AddListener(MusicVolume);
    }

    private void Start()
    {
        sliderMusic.value = PlayerPrefs.GetFloat(AudioManager.MUSIC_KEY, 1f);
    }
    private void OnDisable()
    {
        PlayerPrefs.SetFloat(AudioManager.MUSIC_KEY, sliderMusic.value);
    }
    void MusicVolume(float value)
    {
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) * 20);
    }
}

