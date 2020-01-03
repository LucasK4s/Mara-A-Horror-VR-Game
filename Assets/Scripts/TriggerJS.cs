using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerJS : MonoBehaviour
{
    public bool AlreadyPlayed = false;

    void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag.Equals("Player") == true && AlreadyPlayed == false)
        {
            FindObjectOfType<AudioManager>().Play("Jumpscare1");
            AlreadyPlayed = true;
        }
    }
}
