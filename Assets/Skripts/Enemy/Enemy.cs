using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 60;
    public int scorevalue = 5;
    
    private void Update()
    {
        if(Difficulty.diff == 0)
        {
            health = 60;
        }
        if(Difficulty.diff == 1)
        {
            health = 90;
        }
        if (Difficulty.diff == 2)
        {
            health = 90;
        }
    }

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
        ScoreManager.score += scorevalue;
    }
}
