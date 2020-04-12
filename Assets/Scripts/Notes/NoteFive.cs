using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteFive : MonoBehaviour
{
    public GameObject sub;
    bool trig = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Manager.Instance.fourthTrigger == true && trig == false)
        {
            trig = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    public void PickUp()
    {
        GetComponent<AudioSource>().Play();
        sub.GetComponent<Subtitles>().FithNote();
    }

    public void PutAway()
    {
        GameObject.Find("AS5").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteFive = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
