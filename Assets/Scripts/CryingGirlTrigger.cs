using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryingGirlTrigger : MonoBehaviour
{
    public GameObject ldoor;
    public GameObject rdoor;
    // Update is called once per frame

    private void Update()
    {
        if (Manager.Instance.firstTrigger == true && Manager.Instance.secondTrigger == false && Manager.Instance.cryinggirl == true)
        {
            Manager.Instance.secondTrigger = true;
            GetComponent<AudioSource>().Play();
            ldoor.transform.rotation = Quaternion.RotateTowards(ldoor.transform.rotation, Quaternion.Euler(0, 27, 0), 150);
            rdoor.transform.rotation = Quaternion.RotateTowards(rdoor.transform.rotation, Quaternion.Euler(0, -21, 0), 150);
        }
    }  
}
