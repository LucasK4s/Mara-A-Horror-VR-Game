using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteNine : MonoBehaviour
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
        GameObject.Find("AS9").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteNine = true;
        gameObject.SetActive(false);
    }
}
