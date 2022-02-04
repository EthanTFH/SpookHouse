using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeManagerV1 : MonoBehaviour
{

    public AudioMixer mixer;

    public void SetMasterLevel(float sliderValue) 
    {
        mixer.SetFloat("MasterVolume", Mathf.Log10 (sliderValue) * 20);
    }

    //Dialogue
    public void SetDialogueLevel(float sliderValue)
    {
        mixer.SetFloat("DialogueVolume", Mathf.Log10(sliderValue) * 20);
    }

    //Effects
    public void SetEffectsLevel(float sliderValue)
    {
        mixer.SetFloat("EffectsVolume", Mathf.Log10(sliderValue) * 20);
    }

    public void SetWeatherLevel(float sliderValue)
    {
        mixer.SetFloat("WeatherVolume", Mathf.Log10(sliderValue) * 20);
    }

    public void SetJumpscaresLevel(float sliderValue)
    {
        mixer.SetFloat("JumpScaresVolume", Mathf.Log10(sliderValue) * 20);
    }

    public void SetFootstepsLevel(float sliderValue)
    {
        mixer.SetFloat("FootStepsVolume", Mathf.Log10(sliderValue) * 20);
    }

    //Music
    public void SetMusicLevel(float sliderValue)
    {
        mixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
    }

    public void SetAmbientLevel(float sliderValue)
    {
        mixer.SetFloat("AmbientVolume", Mathf.Log10(sliderValue) * 20);
    }
}
