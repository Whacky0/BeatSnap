using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionManager : MonoBehaviour
{
    ParticleSystem particles;
    bool toco = false;
    private void Awake()
    {
        particles = GetComponent<ParticleSystem>();
        particles.Stop();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

            if (collision.gameObject.tag=="Up")
            {
            particles.Play();
            toco = true;
            }
            if (collision.gameObject.tag == "Down")
            {
            particles.Play();
            toco = true;
        }
            if (collision.gameObject.tag == "Right")
            {
            particles.Play();
            toco = true;
        }
            if (collision.gameObject.tag == "Left")
            {
            particles.Play();
            toco = true;
        }


        
    }

    private void Update()
    {
        if (particles.isPlaying==false && toco)
        {
            Destroy(gameObject);
        }
    }

}
    
