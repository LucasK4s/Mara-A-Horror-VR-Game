using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean grabAction;
    public Animator animator;

    private bool CheckGrab()
    {
        return grabAction.GetState(handType);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckGrab())
        {
            animator.SetTrigger("FadeScene");
        }
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene("Apartment");
    }
}
