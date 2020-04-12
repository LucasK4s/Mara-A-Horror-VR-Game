using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class ClosedDoorInteraction : Valve.VR.InteractionSystem.Interactable
{

    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean grabAction;

    protected override void Update ()
    {
        if (highlightOnHover)
        {
            UpdateHighlightRenderers();

            if (isHovering == false && highlightHolder != null)
                Destroy(highlightHolder);
            
            if(isHovering == true && grabAction.GetState(handType) && !GetComponent<AudioSource>().isPlaying)
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }
}

