using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1 : MonoBehaviour
{
    private bool _forward;
    private bool _back;
    private bool _left;
    private bool _right;
    public float _forwardSpeed = 10.0f;
    private Rigidbody2D _rigidbody;
    public lives logic;
    public bool playerIsAlive = true;
    private int lives = 5;
    public Text Mylives;
    public float _turnspeed = 1.0f;
    private float _turnDirection;
    Vector2 startPos;


    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<lives>();
        Mylives.text = "Lives: " + lives;
        startPos = transform.position;
    }
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        _forward = Input.GetKey(KeyCode.UpArrow);
        _back = Input.GetKey(KeyCode.DownArrow);
        _left = Input.GetKey(KeyCode.LeftArrow);
        _right = Input.GetKey(KeyCode.RightArrow);


    }

    private void FixedUpdate()
    {
        if (_forward && playerIsAlive)
        {
            _rigidbody.AddForce(this.transform.up * _forwardSpeed);
        }

        if (_back && playerIsAlive)
        {
            _rigidbody.AddForce(-this.transform.up* _forwardSpeed*1.5f);
        }

        
        if (_left)
        {
            _turnDirection = 1.0f;
            _rigidbody.AddForce(-this.transform.right * _forwardSpeed * 1.5f);
            _rigidbody.AddTorque(_turnDirection * this._turnspeed * 0.5f);
        }

        if (_right)
        {
            _turnDirection = -1.0f;
            _rigidbody.AddForce(this.transform.right * _forwardSpeed * 1.5f);
            _rigidbody.AddTorque(_turnDirection * this._turnspeed*0.5f);

        }

        if(!_forward && ! _back && !_left && !_right)
        {
            _rigidbody.velocity = Vector3.zero;
            //_rigidbody.angularVelocity = 0.0f;


        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if ((collision.gameObject.tag == "rocks1") || ( collision.gameObject.tag == "rocks2"))
        {
            lives--;
            Mylives.text = "Lives: " + lives;
            transform.position = startPos;
            _rigidbody.velocity = Vector2.zero;

        }

        if(lives==0)
        {
            logic.gameOver();
            playerIsAlive = false;
        }
        
    }

}
