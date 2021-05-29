using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    private void Awake()
    {
        var street = GameObject.Find("Streets");
        player.transform.position = new Vector3(street.transform.position.x - 0.73f, -3.84f, 5); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
