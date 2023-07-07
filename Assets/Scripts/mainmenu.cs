using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    public GameObject onStart;
    public GameObject firstScreen;
    public GameObject ruleScreen;
    public GameObject settingScreen;

    public void playb()
    {
        onStart.SetActive(true);
        firstScreen.SetActive(false);
    }
    public void rulesB()
    {
        firstScreen.SetActive(false);
        ruleScreen.SetActive(true);

    }

    public void backB()
    {
        ruleScreen.SetActive(false);
        firstScreen.SetActive(true);
    }
    public void settings_B()
    {
        firstScreen.SetActive(false);
        settingScreen.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
