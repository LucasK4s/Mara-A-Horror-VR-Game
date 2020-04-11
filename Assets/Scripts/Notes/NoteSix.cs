using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GetComponent<Renderer>().isVisible && gameObject.transform.localScale == Vector3.zero)
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f); 
        }
    }

    public void PickUp()
    {
        GetComponent<AudioSource>().Play();
    }

    public void PutAway()
    {
        GameObject.Find("AS6").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteSix = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
