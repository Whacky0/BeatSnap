using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatsCleaner : MonoBehaviour
{
    public GameObject beats;
    void beatsCleaner()
    {
        foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
        {
            if (gameObj.name == "Obstacles(Clone)" && gameObj.transform.position.y <= -15)
            {
                Destroy(gameObj);
            }

        }
       
    }
    void Update()
    {
        beatsCleaner();
    }
}

