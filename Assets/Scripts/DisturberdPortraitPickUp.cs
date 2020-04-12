using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisturberdPortraitPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPickup()
    {
        StartCoroutine(Coro());
    }

    IEnumerator Coro()
    {
        yield return new WaitForSeconds(5);
        Manager.Instance.tenthTrigger = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!GetComponent<AudioSource>().isPlaying && collision.relativeVelocity.magnitude >= 1)
        {
            GetComponent<AudioSource>().volume = collision.relativeVelocity.magnitude / 10;
            GetComponent<AudioSource>().Play();
        }
    }
}
