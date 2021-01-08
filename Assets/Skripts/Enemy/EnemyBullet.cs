using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 20;
    public Rigidbody2D rb;
    
   
    

    // Use this for initialization
    void Start()
    {
        rb.velocity = -transform.up * speed;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
