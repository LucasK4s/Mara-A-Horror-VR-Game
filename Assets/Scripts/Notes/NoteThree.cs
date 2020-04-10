using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUp()
    {
        GetComponent<AudioSource>().Play();
    }

    public void PutAway()
    {
        GameObject.Find("AS3").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteThree = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
