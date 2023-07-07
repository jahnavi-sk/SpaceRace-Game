using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Rigidbody2D _rb;
    Vector2 startPos;
    
    
    private void Start()
    
    {
        _rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        if (collision.transform.CompareTag("rocks1"))
        {
            Die();
        }

        if (collision.transform.CompareTag("rocks2"))
        {
            Die();
        }
        */

        if(collision.transform.CompareTag("boundary"))
        {
            Die();
        }

    }

        void Die()
        {
            Respawn();
        }


        void Respawn()
        {
            transform.position = startPos;
            _rb.velocity = Vector2.zero;
            
            //_rb.angularVelocity = Vector2.zero;
        }
    

}
