using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRinging : MonoBehaviour
{
    Material mat;
    // Start is called before the first frame update
    public void StopCall()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 3 seconds.
        yield return new WaitForSeconds(3);
        GetComponent<AudioSource>().Stop();
        mat = GetComponent<Renderer>().materials[1];
        mat.DisableKeyword("_EMISSION");
    }
}
