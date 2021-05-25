using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static bool ChooseSong;
    public AudioClip[] list;
    public AudioSource audioSource;
    public AudioClip Snap;
    public static int Bpm;

    // Start is called before the first frame update

    private void Awake()
    {
        list = Resources.LoadAll<AudioClip>("AudioClips");
        PlayThisClip();

    }

    public void PlayThisClip()
    {
        foreach (AudioClip clip in list)
        {
            if (clip.name == "MenuTheme")
            {
                ChooseSong = true;
                audioSource.PlayOneShot(clip);
                Bpm = 120;


            }

        }
    }


   private void Update()
    {
        for (int i = 0; i < 256; i++)
        {
            if (SpectrumData.spectrum[i] >= 20)
            {
                audioSource.PlayOneShot(Snap);
                break;
            }
        }

        }
    
}

