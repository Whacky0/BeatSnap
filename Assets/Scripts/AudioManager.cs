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
    public AudioClip snap;
    // Start is called before the first frame update

    private void Awake()
    {
        
        list = Resources.LoadAll<AudioClip>("AudioClips");
        PlayThisClip();

    }
    private void Start()
    {
        Invoke("playSong", 1.5f);
       
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            audioSource.PlayOneShot(snap);  
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            audioSource.PlayOneShot(snap);
        }
    }
    public void PlayThisClip()
    {
        foreach (AudioClip clip in list)
        {
            if (clip.name == "hexxagon")
            {
                ChooseSong = true;
               PreLoad.PlayOneShot(clip);
                Bpm = 136;

            }

        }
    }

    void playSong()
    {
        foreach (AudioClip clip in list)
        {
            if (clip.name == "hexxagon")
            {
                ChooseSong = true;
                audioSource.PlayOneShot(clip);
                Bpm = 136;


            }

        }
    }



}

