using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutDoor : MonoBehaviour
{
    public GameObject ldoor;
    public GameObject rdoor;
    public float speed;
    private bool geschlossen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (Manager.Instance.secondTrigger == true && Manager.Instance.thirdTrigger == false && other.gameObject.tag == "Player")
        {     
            if (gameObject.GetComponentInParent<AudioSource>().isPlaying)
            {
                gameObject.GetComponentInParent<AudioSource>().Stop();
                Manager.Instance.thirdTrigger = true;
                gameObject.GetComponentInChildren<AudioSource>().Play();
            }
        }
    }

    void Update()
    {
        if (Manager.Instance.thirdTrigger == true)
        {
            var step = speed * Time.deltaTime;
            if (geschlossen == false)
            {
                ldoor.transform.rotation = Quaternion.RotateTowards(ldoor.transform.rotation, Quaternion.Euler(0, 0, 0), step);
                rdoor.transform.rotation = Quaternion.RotateTowards(rdoor.transform.rotation, Quaternion.Euler(0, 0, 0), step);
                if (ldoor.transform.rotation == Quaternion.Euler(0,0,0))
                {
                    geschlossen = true;
                }
            }
        }
    }
}

