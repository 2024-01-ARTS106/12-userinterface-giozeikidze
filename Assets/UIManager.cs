using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }



    public Animator startButton;
    public Animator settingsButton;
    public void OpenSettings()
    {
        startButton.SetBool("isHidden", true);
        settingsButton.SetBool("isHidden", true);


    }
}