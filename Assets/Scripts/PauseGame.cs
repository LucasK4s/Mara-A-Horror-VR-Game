using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseMenu;
    public SteamVR_Action_Boolean pauseAction;
    public SteamVR_Input_Sources handType;

    private bool CheckPauseButton()
    {
        return pauseAction.GetStateDown(handType);
    }

    void Update ()
    {
        if (CheckPauseButton())
        {
            if (Time.timeScale == 1)
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false); 
            }
        }
    }
}
