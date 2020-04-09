using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    Rigidbody rigb;
    private bool triggered = false;
    public float force = 50f;
    public bool forceNegative = false;
    private float sign = 1;
    
    void Start()
    {
        rigb = GetComponent<Rigidbody>();
        if (forceNegative == true)
        {
            sign = -1f;
        }
        else
        {
            sign = 1f;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {   
        
        if( other.gameObject.tag == "Player")
        {
            if (triggered == false)
            {

                //rigb.MovePosition(new Vector3(rigb.position.x, rigb.position.y, rigb.position.z + 0.5f));
                rigb.AddForce(sign * Vector3.forward * force);

                triggered = true;
            }
        }

    }
}
