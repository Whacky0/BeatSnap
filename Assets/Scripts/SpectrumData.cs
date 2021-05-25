using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpectrumData : MonoBehaviour
{
    public static float[] spectrum = new float[256];
    public AudioSource _audioSource;


    private void Update()
    {
        spectrumData();
    }
    void spectrumData()
    {
        _audioSource.GetSpectrumData(spectrum, 0, FFTWindow.Blackman);
        for (int i = 0; i < 256; i++)
        {
           spectrum[i]= Mathf.Round(spectrum[i] * 100);

        }

    }
   
}