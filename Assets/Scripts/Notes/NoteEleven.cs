using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class NoteEleven : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.Instance.sixthTrigger == true && gameObject.GetComponent<MeshRenderer>().enabled == false )
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            GetComponent<Interactable>().enabled = true;
        }
    }

    public void PickUp()
    {
        GetComponent<AudioSource>().Play();
    }

    public void PutAway()
    {
        GameObject.Find("AS11").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteEleven = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
