using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetOpensSlightly : MonoBehaviour
{
    private bool triggered = false;
    public GameObject ldoor;
    public GameObject rdoor;
    public GameObject parent;
    public float speed;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered == false)
        {
            if (other.gameObject.tag == "Player")
            {
                if (parent.GetComponent<AudioSource>().isPlaying)
                {
                    triggered = true;
                    GetComponent<AudioSource>().Play();
                }
            }
        }
    }

    void Update()
    {
        if (triggered == true)
        {
            var step = speed * Time.deltaTime;

            ldoor.transform.rotation = Quaternion.RotateTowards(ldoor.transform.rotation, Quaternion.Euler(0, 42, 0), step);
            rdoor.transform.rotation = Quaternion.RotateTowards(rdoor.transform.rotation, Quaternion.Euler(0, -35, 0), step);
        }
    }
}