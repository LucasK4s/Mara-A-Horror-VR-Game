using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutDoor : MonoBehaviour
{
    private bool triggered = false;
    public GameObject ldoor;
    public GameObject rdoor;
    public float speed;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered == false)
        {
            if (other.gameObject.tag == "Player")
            {
                if (gameObject.GetComponentInParent<AudioSource>().isPlaying)
                {
                    gameObject.GetComponentInParent<AudioSource>().Stop();
                    triggered = true;
                    gameObject.GetComponentInChildren<AudioSource>().Play();
                }
            }
        }
    }

    void Update()
    {
        if (triggered == true)
        {
            var step = speed * Time.deltaTime;

            ldoor.transform.rotation = Quaternion.RotateTowards(ldoor.transform.rotation, Quaternion.Euler(0, 0, 0), step);
            rdoor.transform.rotation = Quaternion.RotateTowards(rdoor.transform.rotation, Quaternion.Euler(0, 0, 0), step);
        }
    }
}

