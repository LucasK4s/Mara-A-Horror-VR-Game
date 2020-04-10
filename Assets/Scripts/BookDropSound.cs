using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookDropSound : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if(!GetComponent<AudioSource>().isPlaying && collision.relativeVelocity.magnitude>=2)
        {
            GetComponent<AudioSource>().volume = collision.relativeVelocity.magnitude / 20;
            GetComponent<AudioSource>().Play();
        }
    }
}
