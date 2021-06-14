using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPM : MonoBehaviour
{
    public int Bpm;
    public static float beatsPerSecond;
    public static float secondsPerBeat;
    public static float velocityY;
    public static float velocityX;
    private void Start()
    {

        if (AudioManager.ChooseSong)
        {
            Bpm = AudioManager.Bpm;
            beatsPerSecond = Bpm / 60;
            secondsPerBeat = 1 / beatsPerSecond;
            velocityY = 5 / secondsPerBeat;
            velocityX = 3 / secondsPerBeat;
            Debug.Log(velocityX);
            Debug.Log(velocityY);
        }


    }




}