using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20;
    public int damage = 20;
    public Rigidbody2D rb;
    


    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.up * speed;
        
    }

   
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
         Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            
            enemy.TakeDamage(damage);
        }
        Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
