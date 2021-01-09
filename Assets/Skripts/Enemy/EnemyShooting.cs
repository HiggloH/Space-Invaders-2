using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject EnemyBullet;
    private float timeLeft;
    private float maxTime;

    private void Start()
    {
        if(Difficulty.diff == 0)
        {
            maxTime = 3;
        }

        if (Difficulty.diff == 1)
        {
            maxTime = 2;
        }

        if (Difficulty.diff == 2)
        {
            maxTime = 1;
        }

        timeLeft = maxTime;
    }

    private void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            Shoot();
            timeLeft = maxTime;
        }
        
    }

    private void Shoot()
    {
        Instantiate(EnemyBullet, firePoint.position, firePoint.rotation);
    }
}
