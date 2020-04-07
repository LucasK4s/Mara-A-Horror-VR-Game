using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ResetAfterGrab : Valve.VR.InteractionSystem.Throwable
{
    public Transform handler;
    public Transform door;

    protected override void OnDetachedFromHand(Hand hand)
    {
        attached = false;

        onDetachFromHand.Invoke();

        hand.HoverUnlock(null);

        rigidbody.interpolation = hadInterpolation;
        
        Vector3 velocity;
        Vector3 angularVelocity;

        GetReleaseVelocities(hand, out velocity, out angularVelocity);

        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        //_________________________________________________
        transform.position = handler.transform.position;
        transform.rotation = handler.transform.rotation;

        Rigidbody rbhandler = handler.GetComponent<Rigidbody>();

        rbhandler.velocity = Vector3.zero;
        rbhandler.angularVelocity = Vector3.zero;


        door.GetComponent<Rigidbody>().velocity = velocity;
        door.GetComponent<Rigidbody>().angularVelocity = angularVelocity;

    }
}
