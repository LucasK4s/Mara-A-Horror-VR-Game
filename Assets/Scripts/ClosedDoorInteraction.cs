using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ClosedDoorInteraction : MonoBehaviour
{
    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean grabAction;
    // Start is called before the first frame update


    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Player") && grabAction.GetState(handType) && !GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
