using UnityEngine;
using System.Collections;

public class PhoneRings : MonoBehaviour
{
    public GameObject note6;
    Material mat;
    bool hasPlayed= false;
    void Update()
    {   if(Manager.Instance.thirdTrigger == true && Manager.Instance.fourthTrigger == false)
        {
            Manager.Instance.fourthTrigger = true;
            //Start the coroutine we define below named ExampleCoroutine.
            StartCoroutine(ExampleCoroutine());
        }
        if(hasPlayed == true && !GetComponent<AudioSource>().isPlaying)
        {
            Manager.Instance.fithTrigger = true;
            mat = GetComponent<Renderer>().materials[1];
            mat.DisableKeyword("_EMISSION");
            note6.SetActive(true);
        }
    }

    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(180);
        GameObject.Find("PianoImpactOnPhoneTrigger").GetComponent<AudioSource>().Play();

        StartCoroutine(Coro());

    }

    IEnumerator Coro()
    {
        yield return new WaitForSeconds(13);
        mat = GetComponent<Renderer>().materials[1];
        mat.EnableKeyword("_EMISSION");
        GetComponent<AudioSource>().Play();

        hasPlayed = true;
    }
}