using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start_script : MonoBehaviour
{
    public GameObject onStart;
    public GameObject firstScreen;
    
    public void activate()
    {
        onStart.SetActive(true);
        firstScreen.SetActive(false);
    }
}
