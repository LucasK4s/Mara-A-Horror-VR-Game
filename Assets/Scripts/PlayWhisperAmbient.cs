using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWhisperAmbient : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Manager.Instance.playWhisper == true && GetComponent<AudioSource>().isPlaying == false && Manager.Instance.lightsOut == false)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
