using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSButton2 : MonoBehaviour
{

    public void TriggerJS()
    {
        FindObjectOfType<AudioManager>().Play("Jumpscare2");
    }
}