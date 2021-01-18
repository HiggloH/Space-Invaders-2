using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Weapon : MonoBehaviour
{
    public AudioSource shoot;

    public Transform[] firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint[0].position, firePoint[0].rotation);
        shoot.Play();
    }
}
