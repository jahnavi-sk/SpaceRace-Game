using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 30.0f;
    public lives logic;

    [SerializeField] Text countdownText;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<lives>();
        currentTime = startingTime;
        //countdownText= GetComponent<>
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime<=0)
        {
            logic.gameOver();
            currentTime = 0;
            
        }
    }



}
