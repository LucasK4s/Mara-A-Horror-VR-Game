using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteEight : MonoBehaviour
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
        GameObject.Find("AS8").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteEight = true;
        gameObject.SetActive(false);
    }
}
