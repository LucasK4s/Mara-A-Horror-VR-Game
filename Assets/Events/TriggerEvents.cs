using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public Rigidbody trigger;
    public GameObject destroy;
    void OnTriggerEnter(Collider other)
    {
        trigger.GetComponent<Rigidbody>().AddForce(Vector3.forward*10, ForceMode.Acceleration);
        Destroy(destroy);
    }
    
}
