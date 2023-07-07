using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocks2 : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D _rigidbody;
    public float xAngle = 1.0f;
    public float yAngle = 1.0f;
    public float zAngle = 0.0f;
    private Vector2 screenBounds;


    private void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody2D>();
        _rigidbody.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));


    }

    private void Update()
    {
        //_rigidbody.transform.Rotate(xAngle / 4, yAngle / 4, zAngle, Space.Self);
        //_rigidbody.transform.Rotate(xAngle / 4, yAngle / 4, zAngle, Space.World);
        //Destroy(gameObject, 8);
        if (transform.position.x < -screenBounds.x * 2)
        {
            Destroy(this.gameObject);
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }

    
}
