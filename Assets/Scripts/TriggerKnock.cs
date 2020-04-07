using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKnock: MonoBehaviour
{ 
    void OnTriggerExit(Collider target)
    {
        if (target.gameObject.tag.Equals("Player") == true && Manager.Instance.firstTrigger == false)
        {
            GetComponent<AudioSource>().Play();
            Manager.Instance.firstTrigger = true;
        }
    }
}
