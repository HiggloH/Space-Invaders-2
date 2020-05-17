using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject EnemyBullet;
    private float i = 0;
    private float frameCount = 0;


    private void Shoot(){
        Instantiate(EnemyBullet, firePoint.position, firePoint.rotation);
    }    
    void Update()
    {
        frameCount++;

        if (frameCount > 60) {
            frameCount = 0;
            i++;
            if(i < 1000){
                Shoot();
            }
        }
    }
}
