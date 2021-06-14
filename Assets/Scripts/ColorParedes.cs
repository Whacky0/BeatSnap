using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorParedes : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
      StartCoroutine(InsColor());
    }

    IEnumerator InsColor()
    {
        var wallU = GameObject.Find("WallU");
        var wallD = GameObject.Find("WallD");
        var wallL = GameObject.Find("WallL"); 
        var wallR = GameObject.Find("WallR");

        if (InstantiateObstacles.posO==3 && InstantiateObstacles.insO)
        {
            var color = wallU.GetComponent<SpriteRenderer>();
            Color hideColor= new Color();
            hideColor.a = 1;
            hideColor.r = 0.5f;
            color.color = hideColor;
            InstantiateObstacles.insO = false;
            yield return new WaitForSeconds(BPM.secondsPerBeat / 2);

        }
        if (InstantiateObstacles.posO == 2 && InstantiateObstacles.insO)
        {
            var color = wallD.GetComponent<SpriteRenderer>();
            Color hideColor = new Color();
            hideColor.a = 1;
            hideColor.r = 0.5f;
            color.color = hideColor;
            InstantiateObstacles.insO = false;
            yield return new WaitForSeconds(BPM.secondsPerBeat / 2);
        }
        if (InstantiateObstacles.posO == 1 && InstantiateObstacles.insO)
        {
            var color = wallL.GetComponent<SpriteRenderer>();
            Color hideColor = new Color();
            hideColor.a = 1f;
            hideColor.r = 0.5f;
            color.color = hideColor;
            InstantiateObstacles.insO = false;
            yield return new WaitForSeconds(BPM.secondsPerBeat / 2);
        }
        if (InstantiateObstacles.posO == 0 && InstantiateObstacles.insO)
        {
            var color = wallR.GetComponent<SpriteRenderer>();
            Color hideColor = new Color();
            hideColor.a = 1;
            hideColor.r = 0.5f;
            color.color = hideColor;
            InstantiateObstacles.insO = false;
            yield return new WaitForSeconds(BPM.secondsPerBeat / 2);
        }

        if (InstantiateObstacles.insO == false)
        {
            var colorU = wallU.GetComponent<SpriteRenderer>();
            var colorD = wallD.GetComponent<SpriteRenderer>();
            var colorR = wallR.GetComponent<SpriteRenderer>();
            var colorL = wallL.GetComponent<SpriteRenderer>();


            Color hideColor = new Color();
            hideColor.a = 0f;
            colorU.color = hideColor;
            colorD.color = hideColor;
            colorR.color = hideColor;
            colorL.color = hideColor;
            yield return new WaitForSeconds(BPM.secondsPerBeat / 2);
        }
    }
}
