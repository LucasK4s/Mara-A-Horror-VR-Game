using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    private bool triggered = false;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (triggered == false)
        {
            if (other.gameObject.tag == "Player")
            {
                GetComponent<AudioSource>().Play();
                triggered = true;
            }
        }
    }    
}
