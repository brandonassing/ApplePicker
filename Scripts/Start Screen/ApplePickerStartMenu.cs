using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ApplePickerStartMenu : MonoBehaviour
{
    public Button easyButton, medButton, hardButton, exitButton;
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        easyButton.GetComponentInChildren<Text>().text = "Easy";
        medButton.GetComponentInChildren<Text>().text = "Medium";
        hardButton.GetComponentInChildren<Text>().text = "Hard";
        exitButton.GetComponentInChildren<Text>().text = "Exit";
    }
    public void EasyStart()
    {
        Application.LoadLevel("_Scene_0");
    }
    public void MediumStart()
    {
        Application.LoadLevel("_Scene_1");
    }
    public void HardStart()
    {
        Application.LoadLevel("_Scene_2");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit(); 
    }
    public void Exit()
    {
        Application.Quit();
    }
}
