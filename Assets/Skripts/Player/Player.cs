using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public AudioSource hit;

    public int health = 100;
    public int maxHealth = 100;

    public HealthBar healthBar;

    private void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage (int damage)
    {
        health -= damage;
        Debug.Log(health);


        hit.Play();

        healthBar.SetHealth(health);

        if (health == 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Application.LoadLevel(7); 
    }
}
