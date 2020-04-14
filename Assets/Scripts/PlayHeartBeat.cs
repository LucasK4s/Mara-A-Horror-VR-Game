using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHeartBeat : MonoBehaviour
{
    bool triggered = false;
    bool decrease = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.Instance.thirdTrigger == true && triggered == false && !GetComponent<AudioSource>().isPlaying)
        {
            triggered = true;
            GameObject.Find("Ambient1").GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().Play();
            StartCoroutine(coro());
        }

        if (decrease == true && GetComponent<AudioSource>().volume > 0.12)
        {
            GetComponent<AudioSource>().volume += -0.005f;
        }
    }

    IEnumerator coro()
    {
        yield return new WaitForSeconds(6);
        decrease = true;
    }
}
