using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Book6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.Instance.NoteSeven == true && GetComponent<Interactable>().enabled == false)
        {
            GetComponent<Interactable>().enabled = true;
        }
    }
}
