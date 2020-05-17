using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 60;
    
   
    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health == 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
