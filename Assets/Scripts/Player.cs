using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    bool click;
    private void Awake()
    {
        var street = GameObject.Find("Streets");
        player.transform.position = new Vector3(street.transform.position.x - 0.73f, -3.84f, 5); 
    }

    void inputPlayer()
    {
        var street = GameObject.Find("Streets");
        if (Input.GetMouseButtonDown(0))
        {
            click = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position= new Vector3(street.transform.position.x, -3.84f, 5);
        }
        if (Input.GetKey(KeyCode.J))
        {
            player.transform.position = new Vector3(street.transform.position.x + 0.73f*2, -3.84f, 5);
        }

    }
    void MoverPlayer()
    {
        if (click)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit.transform.CompareTag("Street"))
            {
                Debug.Log("Toco Streets");
                player.transform.position = new Vector3(player.transform.position.x, hit.transform.position.y, player.transform.position.z);
                click = false;
            }
            else
            {
                player.transform.position = player.transform.position;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        inputPlayer();
       // MoverPlayer();
    }
}
