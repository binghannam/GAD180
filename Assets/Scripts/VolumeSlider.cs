using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer Mixer;
 
    public void SetAudioLevel(float sliderValue)
    {
        Mixer.SetFloat("Audio Vol", Mathf.Log10(sliderValue) * 20);
    }
}
