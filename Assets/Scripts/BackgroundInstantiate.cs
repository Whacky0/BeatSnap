using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundInstantiate : MonoBehaviour
{
    public GameObject player;
    public static bool  cambiocolor = false;
    public AudioSource audioSourceGame;
    float delay = 0;
    /*
    private void Awake()
    {
        RenderSettings.skybox.SetColor("_Tint", new Color(0.2f, 0.5f, 0.5f));
        //left
        var BotomLeftEdge = new Vector3(Screen.width / Screen.width / 10, Screen.height / Screen.height / Screen.height);
        //right
        var BotomRightEdge = new Vector3(Screen.width / Screen.width / 4, Screen.height / Screen.height / Screen.height);
        /*
        //Streets
        street.transform.position = new Vector3(BotomLeftEdge.x - 0.75f, BotomLeftEdge.y, 5);
        Instantiate(street, new Vector3(BotomRightEdge.x + 0.75f, BotomRightEdge.y, 5), Quaternion.identity);
        
    }
    */
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Camera.main.backgroundColor = new Color(0.2f, 0.2f, 0.5f);
    }
    void Update()
    {
        if (delay <=0) {
            skybox();
            return;
        }
        else
        {
            delay -= Time.deltaTime;


        }
    }

    void skybox()
    {

     if (SpectrumData._frequBand[6] > 30 && !cambiocolor)
            {
            cambiocolor = true;
            Camera.main.backgroundColor = new Color(0.7f, 0.5f, 0.7f);
            delay = BPM.secondsPerBeat;

        }
        else if(SpectrumData._frequBand[6] > 30 && cambiocolor)
        {
            cambiocolor = false;
            Camera.main.backgroundColor = new Color(0.2f, 0.2f, 0.5f);
            delay = BPM.secondsPerBeat;


        }
        // Update is called once per frame

    }

    
}
