using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSeven : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Manager.Instance.fithTrigger == true && Manager.Instance.sixthTrigger == false)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    public void PickUp()
    {
        GetComponent<AudioSource>().Play();
        Manager.Instance.sixthTrigger = true;
    }

    public void PutAway()
    {
        GameObject.Find("AS7").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteSeven = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
