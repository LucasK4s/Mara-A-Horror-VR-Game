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
    public GameObject ambientSource;
    private bool isFading = false;

    private bool CheckGrab()
    {
        return grabAction.GetState(handType);
    }

    // Update is called once per frame
    void Update()
    {   
        if (isFading == false)
        {
            if (CheckGrab() || transform.position.y < -4)
            {
                isFading = true;
                GetComponent<AudioSource>().Play(); 
                animator.SetTrigger("FadeScene");
            }
        }
        if(isFading == true)
        {
            ambientSource.GetComponent<AudioSource>().volume += -0.05f;
        }
        
    }


    public void OnFadeComplete()
    {
        SceneManager.LoadScene("Apartment");
    }
}
