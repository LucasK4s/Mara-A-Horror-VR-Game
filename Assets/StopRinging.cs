using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRinging : MonoBehaviour
{
    Material mat;
    // Start is called before the first frame update
    public void StopCall()
    {
        GetComponent<AudioSource>().Stop();
        mat = GetComponent<Renderer>().materials[1];
        mat.DisableKeyword("_EMISSION");
    }
}
