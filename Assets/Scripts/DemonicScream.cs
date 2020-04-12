using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonicScream : MonoBehaviour
{
    bool hasPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.Instance.tenthTrigger == true && hasPlayed == false)
        {
            GetComponent<AudioSource>().Play();
            hasPlayed = true;
        }        
    }


}
