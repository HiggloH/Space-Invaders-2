using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject EnemyBullet;
    private float secondsBetweenShoot;


    private void Start()
    {
        if(Difficulty.diff == 0)
        {
            secondsBetweenShoot = 3;
        }

        if (Difficulty.diff == 1)
        {
            secondsBetweenShoot = 2;
        }

        if (Difficulty.diff == 2)
        {
            secondsBetweenShoot = 1;
        }

        StartCoroutine("WhenToShoot");
    }

    private void Shoot()
    {
        Instantiate(EnemyBullet, firePoint.position, firePoint.rotation);
    }

    IEnumerable WhenToShoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(secondsBetweenShoot);
            Shoot();
        }
    }
}
