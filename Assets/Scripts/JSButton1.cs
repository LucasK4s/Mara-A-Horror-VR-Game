using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSButton1 : MonoBehaviour
{

    public void TriggerJS()
    {
        FindObjectOfType<AudioManager>().Play("Jumpscare1");
    }
}