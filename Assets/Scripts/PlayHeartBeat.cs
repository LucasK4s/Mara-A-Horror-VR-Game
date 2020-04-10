using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHeartBeat : MonoBehaviour
{

    bool decrease = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.Instance.thirdTrigger == true && Manager.Instance.fourthTrigger == false && !GetComponent<AudioSource>().isPlaying)
        {
            GameObject.Find("Ambient1").GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().Play();
            StartCoroutine(coro());
        }

        if (decrease == true && GetComponent<AudioSource>().volume > 0.085)
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
