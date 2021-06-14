using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] projectile= new GameObject[4];
    public GameObject heart;
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
    int pos;
    float delay = 0;




    public void SwipePc()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //save began touch 2d point
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //save ended touch 2d point
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            //normalize the 2d vector
            currentSwipe.Normalize();

            //swipe upwards
            if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
        {
                Debug.Log("up swipe");
                pos = 1;
            }
            //swipe down
            if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
        {
                Debug.Log("down swipe");
                pos = 2;
            }
            //swipe left
            if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
        {
                Debug.Log("left swipe");
                pos = 3;
            }
            //swipe right
            if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
        {
                Debug.Log("right swipe");
                pos = 4;
            }
        }
    }
    void instantiateProjectiles()
    {
        switch (pos)
        {
            case 1:
                Instantiate(projectile[0], new Vector3(0, 0,10), Quaternion.identity);
                pos = 0;
                break;
            case 2:
                Instantiate(projectile[1], new Vector3(0, 0,10), Quaternion.Euler (0,0,180));
                pos = 0;
                break;
            case 3:
                Instantiate(projectile[2], new Vector3(0, 0,10), Quaternion.Euler(0, 0, 90));
                pos = 0;
                break;
            case 4:
                Instantiate(projectile[3], new Vector3(0, 0,10), Quaternion.Euler(0, 0, 270));
                pos = 0;
                break;
            default: break;
        }
    }

    void moveobjects()
    {
        var up = GameObject.FindGameObjectsWithTag("Up");
        var down = GameObject.FindGameObjectsWithTag("Down");
        var left = GameObject.FindGameObjectsWithTag("Left");
        var right = GameObject.FindGameObjectsWithTag("Right");

        foreach (var upArrow in up)
        {
            if (upArrow.transform.position.y < 10)
            {
                upArrow.transform.position = new Vector3(0, upArrow.transform.position.y + 0.1f, 10);
            }
        }
        foreach (var downArrow in down)
        {
            if (downArrow.transform.position.y > -10)
            {
                downArrow.transform.position = new Vector3(0, downArrow.transform.position.y - 0.1f, 10);
            }
        }
        foreach (var leftArrow in left)
        {
            if (leftArrow.transform.position.x > -10)
            {
                leftArrow.transform.position = new Vector3(leftArrow.transform.position.x - 0.1f, 0, 10);
            }
        }
        foreach (var rightArrow in right)
        {
            if (rightArrow.transform.position.x < 10)
            {
                rightArrow.transform.position = new Vector3(rightArrow.transform.position.x + 0.1f, 0, 10);
            }
        }
        
       
       
    }

    // Update is called once per frame
    void Update()
    {
        SwipePc();
        instantiateProjectiles();
        moveobjects();
        heartBeat();
        // MoverPlayer();
    }

    void heartBeat()
    {
        if (delay <= 0)
        {
            if (heart.transform.localScale.x == 0.2f) { 
            heart.transform.localScale = new Vector2(0.1f, 0.1f);
            }
            else
            {
                heart.transform.localScale = new Vector2(0.2f, 0.2f);
            }
            delay = BPM.secondsPerBeat;

            return;
        }
        else
        {
            delay -= Time.deltaTime;


        }

    }
}
