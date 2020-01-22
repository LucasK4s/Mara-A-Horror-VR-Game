using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PauseGame2 : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;
    public SteamVR_Action_Boolean pauseAction;
    public SteamVR_Input_Sources handType;

    private bool CheckPauseButton()
    {
        return pauseAction.GetState(handType);
    }

    void Start()
    {
        StartCoroutine(PauseCoroutine());
    }

    IEnumerator PauseCoroutine()
    {   while (true)
        {
            if (CheckPauseButton())
            {
                if (gamePaused == false)
                {
                    Time.timeScale = 0;
                    gamePaused = true;
                    pauseMenu.SetActive(true);
                    yield return new WaitForSeconds(1.5f);
                }
                else
                {
                    pauseMenu.SetActive(false);
                    gamePaused = false;
                    Time.timeScale = 1;
                    yield return new WaitForSeconds(1.5f);
                }
            }
        }
    }
}
