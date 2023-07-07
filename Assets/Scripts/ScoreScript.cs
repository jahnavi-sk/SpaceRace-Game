using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    //public Text Mylives;
    private int ScoreNum;
    //private int lives;

    private void Start()
    {
        ScoreNum = 0;
        //lives = 5;
        MyscoreText.text = "Score: " + ScoreNum;
        //Mylives.text = "Live: " + lives;
    }

    private void OnTriggerEnter2D(Collider2D finish_line)
    {
        if(finish_line.tag == "finishline")
        {
            ScoreNum += 1;
            MyscoreText.text = "Score: " + ScoreNum;
        }
        
    }


}
