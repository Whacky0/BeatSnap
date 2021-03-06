using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObstacles : MonoBehaviour
{
    public GameObject obstacles;
    public SpriteRenderer sprite;
    float delay = 0;


     private void Update()
     {
         moveObjects();
        colorManager();

         if (delay <= 0)
         {

             instantiateObstacles();
             return;
         }
         else
         {
             delay -= Time.deltaTime;


         }

     }
    

  
    void instantiateObstacles()
    {
        int rand = Random.Range(0, 4);
        Vector3[] ins= new Vector3[4];
        ins[0] = new Vector3(3, 0, 10);
        ins[1] =  new Vector3(-3, 0, 10);
        ins[2]= new Vector3(0, -5, 10); 
        ins[3]=  new Vector3(0, 5, 10);

        Quaternion[] q = new Quaternion[4];
        q[0]=Quaternion.Euler(0, 0, 270);
        q[1] = Quaternion.Euler(0, 0, 90);
        q[2] = Quaternion.Euler(0, 0, 180);
        q[3] = Quaternion.identity;


        if (SpectrumData._frequBandPreLoad[6]> SpectrumData.PreAudioSpec.Pop()+30) {
            Instantiate(obstacles, ins[rand], q[rand]);
            delay = BPM.secondsPerBeat/2;
        }
        else if(SpectrumData._frequBandPreLoad[1] > 30)
        {

            Instantiate(obstacles, ins[rand], q[rand]);
            delay = BPM.secondsPerBeat ;
        }
        

    }



    void moveObjects()
    {

        var beats = GameObject.FindGameObjectsWithTag("Obstacles");
        foreach (var posBeats in beats)
        {
            if (posBeats.transform.position.y >= 0 && posBeats.transform.position.x==0)
            {
                posBeats.transform.position = new Vector3(posBeats.transform.position.x, posBeats.transform.position.y - 0.1f/2, posBeats.transform.position.z);
            }
            if (posBeats.transform.position.x >= 0 && posBeats.transform.position.y == 0)
            {
                posBeats.transform.position = new Vector3(posBeats.transform.position.x - 0.1f/4, posBeats.transform.position.y, posBeats.transform.position.z);
            }
            if (posBeats.transform.position.x <= 0 && posBeats.transform.position.y == 0)
            {
                posBeats.transform.position = new Vector3(posBeats.transform.position.x+0.1f/4, posBeats.transform.position.y, posBeats.transform.position.z);
            }
            if (posBeats.transform.position.y <=0 && posBeats.transform.position.x == 0)
            {
                posBeats.transform.position = new Vector3(posBeats.transform.position.x, posBeats.transform.position.y + 0.1f/2, posBeats.transform.position.z);
            }
        }
    }
    void colorManager()
    {
        var obs = GameObject.FindGameObjectsWithTag("Obstacles");
 
        foreach(var o in obs) {
           var sp = o.GetComponent<SpriteRenderer>();
        if (BackgroundInstantiate.cambiocolor)
        {
            sp.color = new Color(0.2f, 0.5f, 0.5f);
        }
        else
        {
            sp.color = new Color(0.7f, 0.5f, 0.7f);

        }
        }
    }
}
