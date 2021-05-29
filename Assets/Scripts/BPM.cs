using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPM : MonoBehaviour
{
    public int Bpm;
    public static float beatsPerSecond;
    public static float secondsPerBeat;

    private void Start()
    {

        if (AudioManager.ChooseSong)
        {
            Bpm = AudioManager.Bpm;
            beatsPerSecond = Bpm / 60;
            secondsPerBeat = 1 / beatsPerSecond;
            Debug.Log(secondsPerBeat);
        }


    }




}