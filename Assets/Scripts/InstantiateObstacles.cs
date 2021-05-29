using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObstacles : MonoBehaviour
{
    public GameObject obstacles;
    float delay = 0;


    private void Update()
    {
        moveObjects();


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
        if (SpectrumData._frequBandPreLoad[6]>=22) { 
        var streets = GameObject.FindGameObjectsWithTag("Street");
         int  rand = Random.Range(0, 2);
        Instantiate(obstacles, new Vector3(streets[rand].transform.position.x+0.5f, streets[rand].transform.position.y + 5, 5), Quaternion.identity);
            delay = 0.5f;

        }
    }

    void moveObjects()
    {

        var beats = GameObject.FindGameObjectsWithTag("Obstacles");
        foreach (var posBeats in beats)
        {
            posBeats.transform.position = new Vector3(posBeats.transform.position.x , posBeats.transform.position.y - 0.035f, posBeats.transform.position.z);
            if (posBeats.transform.position.y <= -15)
            {
                posBeats.transform.position = new Vector3(posBeats.transform.position.x, -16, posBeats.transform.position.z);
            }
        }
    }
}
