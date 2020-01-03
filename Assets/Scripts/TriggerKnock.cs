using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKnock: MonoBehaviour
{
    public bool AlreadyPlayed = false;

    void OnTriggerExit(Collider target)
    {
        if (target.gameObject.tag.Equals("Player") == true && AlreadyPlayed == false)
        {
            GetComponent<AudioSource>().Play();
            AlreadyPlayed = true;
        }
    }
}
