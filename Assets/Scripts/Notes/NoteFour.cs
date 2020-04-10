using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteFour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Manager.Instance.secondTrigger == true && !gameObject.GetComponent<Renderer>().isVisible )
        {
            gameObject.SetActive(false);
        }
    }

    public void PickUp()
    {
        GetComponent<AudioSource>().Play();
    }

    public void PutAway()
    {
        GameObject.Find("AS4").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteFour = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
