using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class chancescipt : MonoBehaviour
{

    public Text Mychances;   //myscore --> mychances
    private int lives;  //scorenum --> lives

    private void Start()
    {
        lives = 5;
        Mychances.text = "Lives: " + lives;
    }


    private void OnTriggerEnter2D(Collider2D finish_line)
    {
        if (finish_line.tag == "finishline")
        {
            lives -= 1;
            Mychances.text = "Score: " + lives;
        }

        if(finish_line.tag =="rocks1")
        {

        }
    }


}
