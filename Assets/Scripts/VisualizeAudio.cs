using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizeAudio : MonoBehaviour
{
    public GameObject puntos;
    GameObject[] cubos = new GameObject[64];
    public float maxScale;
    SpriteRenderer[] color = new SpriteRenderer[64];
    // Start is called before the first frame update
    void Awake()
    {
        float b = 0;
        for (int i = 0; i < 64; i++)
        {
            b += 0.09f;
            Instantiate(puntos, new Vector3(-2.9f + b, puntos.transform.position.y, puntos.transform.position.z), Quaternion.identity);
        }
        for (int i = 0; i < 64; i++)
        {
            var beats = GameObject.FindGameObjectsWithTag("Visual");
            cubos[i] = beats[i];
        }


    }

    // Update is called once per frame
    void Update()
    {
        cambioColorYescala();

    }

    void cambioColorYescala()
    {
        float b = 0;
        int j = 0;
        int k = 31;
        for (int i = 32; i >= 0; i--)
        {
            cubos[j].transform.localScale = new Vector3(0.4f, (SpectrumData.spectrum[i] * maxScale) + 1, 10);
            j += 1;

        }
        for (int i = 0; i <= 32; i++)
        {
            cubos[k].transform.localScale = new Vector3(0.4f, (SpectrumData.spectrum[i] * maxScale) + 1, 10);
            k += 1;

        }
        for (int i = 0; i < 64; i++)
        {
            b = Random.Range(0, 100);
            b = b / 100;
            color[i] = cubos[i].GetComponent<SpriteRenderer>();
            color[i].color = new Color(b, color[i].color.g, color[i].color.b);
        }
    }
}
