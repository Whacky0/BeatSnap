using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpectrumData : MonoBehaviour
{
    public float[] spectrum = new float[512];
    public  float[] spectrumPreload = new float[512];
    public static float[] _frequBand = new float[8];
    public static float[] _frequBandPreLoad = new float[8];
    public  float[] test = new float[8];



    public AudioSource _audioSource;
    public  AudioSource preload;

    private void Update()
    {
        spectrumData();
        frequenciBand();
        frequenciBandPreload();

        test = _frequBand;
    }
    void spectrumData()
    {
        _audioSource.GetSpectrumData(spectrum, 0, FFTWindow.Blackman);
        preload.GetSpectrumData(spectrumPreload, 0, FFTWindow.Blackman);

        spectrum[0] = spectrum[0] * 100;
        spectrumPreload[0] = spectrum[0] * 100;



    }
    void frequenciBand()
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;
            if (i == 7)
            {
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                average += spectrum[count] * (count + 1);
                count++;
            }
            average /= count;
            _frequBand[i] = average * 10;
        }
    }
    void frequenciBandPreload()
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;
            if (i == 7)
            {
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                average += spectrumPreload[count] * (count + 1);
                count++;
            }
            average /= count;
            _frequBandPreLoad[i] = average * 10;
        }
    }
}