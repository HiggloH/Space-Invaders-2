using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    public float minPosX = -8.25f;
    public float maxPosX = 8.25f;
    public float moveSpeed = 10f;

    public string dir;

    void Start()
    {
        if(Difficulty.diff == 0)
        {
            moveSpeed = 3;
        }
        if (Difficulty.diff == 1)
        {
            moveSpeed = 5;
        }
        if (Difficulty.diff == 2)
        {
            moveSpeed = 10;
        }
    }

    void Update()
    {
        if(transform.position.x >= minPosX && dir != "right")
        {
            MoveMinusX();
        }
        else if(dir == "left")
        {
            dir = "right";
        }

        if (transform.position.x <= maxPosX && dir != "left")
        {
            MoveX();
        }
        else if(dir == "right")
        {
            dir = "left";
        }
    }

    private void MoveMinusX()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        Debug.Log("Moveing left");
    }

    private void MoveX()
    {
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        Debug.Log("Moveing right");
    }
}
