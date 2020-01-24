using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookShelfTriggerScript : MonoBehaviour
{
    void FallDown()
    {
        GetComponent<Rigidbody>().AddForce(-transform.forward * 50);
    }
}
