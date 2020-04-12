using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScaryAmbientSound : MonoBehaviour
{
    bool hasplayed = false;

    // Update is called once per frame
    void Update()
    {
        if (Manager.Instance.eleventhTrigger && !hasplayed)
        {
            GetComponent<AudioSource>().Play();
            hasplayed = true;
        }
    }
}
