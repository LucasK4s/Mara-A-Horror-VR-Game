using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class NoteEleven : MonoBehaviour
{
    bool trig = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.Instance.NoteSeven == true && gameObject.GetComponent<MeshRenderer>().enabled == false && trig == false)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            GetComponent<BoxCollider>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }

    public void PickUp()
    {
        GetComponent<AudioSource>().Play();
    }

    public void PutAway()
    {
        trig = true;
        GameObject.Find("AS11").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteEleven = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
