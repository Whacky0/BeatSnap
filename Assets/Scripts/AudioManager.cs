using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static bool ChooseSong;
    public AudioClip[] list;
    public AudioSource PreLoad;
    public AudioSource audioSource;
    public static int Bpm;

    // Start is called before the first frame update

    private void Awake()
    {
        list = Resources.LoadAll<AudioClip>("AudioClips");
        PlayThisClip();

    }
    private void Start()
    {
        Invoke("playSong", 3f);
       
    }

    public void PlayThisClip()
    {
        foreach (AudioClip clip in list)
        {
            if (clip.name == "Synthwave Theme")
            {
                ChooseSong = true;
               PreLoad.PlayOneShot(clip);
                Bpm = 120;


            }

        }
    }

    void playSong()
    {
        foreach (AudioClip clip in list)
        {
            if (clip.name == "Synthwave Theme")
            {
                ChooseSong = true;
                audioSource.PlayOneShot(clip);
                Bpm = 120;


            }

        }
    }



}

