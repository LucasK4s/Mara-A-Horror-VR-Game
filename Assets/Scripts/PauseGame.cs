using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;
    public SteamVR_Action_Boolean pauseAction;
    public SteamVR_Input_Sources handType;

    private bool CheckPauseButton()
    {
        return pauseAction.GetState(handType);
    }

    void Update ()
    {
        if (CheckPauseButton())
        {
            if (gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }
}
