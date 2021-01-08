using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject EnemyBullet;
    private float i = 0;
    private float frameCount = 0;
    private float secondsBetweenShoot;


    private void Start()
    {
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
