using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundInstantiate : MonoBehaviour
{
    public GameObject street;

    private void Awake()
    {
        //left
        var BotomLeftEdge = new Vector3(Screen.width / Screen.width / 10, Screen.height / Screen.height / Screen.height);
        //right
        var BotomRightEdge = new Vector3(Screen.width / Screen.width / 4, Screen.height / Screen.height / Screen.height);
        street.transform.position = new Vector3(BotomLeftEdge.x - 0.75f, BotomLeftEdge.y, 10);
        Instantiate(street, new Vector3(BotomRightEdge.x + 0.75f, BotomRightEdge.y, 10), Quaternion.identity);

    }
    void Update()
    {
        StartCoroutine(skybox());
    }

    IEnumerator skybox()
    {
        bool beat=false;
        for (int i = 0; i < 256; i++)
        {
            if (SpectrumData.spectrum[i] >= 20)
            {
                RenderSettings.skybox.SetColor("_Tint", new Color(0.7f, 0.5f, 0.5f));
                beat = true;
                break;
            }

            else
            {
                RenderSettings.skybox.SetColor("_Tint", new Color(0.2f, 0.5f, 0.5f));

            }
        }

        if (beat)
        {
            yield return new WaitForSeconds(1.5f);

        }
        // Update is called once per frame

    }
}
