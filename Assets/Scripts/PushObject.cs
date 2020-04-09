using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObject : MonoBehaviour
{
    public GameObject obj;
    private bool triggered = false;
    Rigidbody rigb;
    public bool right = false;
    public bool left = false;
    public bool forward = true;
    public bool back = false;

    public float force = 100;
    public float leviTime = 10f;
    // Start is called before the first frame update
    void Awake()
    {
        rigb = obj.GetComponent<Rigidbody>();
    }

    private void Update()
    {
       if(triggered == true)
        {
            if (leviTime >= 0f && triggered == true)
            {

                leviTime -= Time.deltaTime;
                Debug.Log(leviTime);
            }
            else
            {
                rigb.useGravity = true;
                enabled = false;
            }
        }
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (triggered == false)
        {
            if (other.gameObject.tag == "Player")
            {
                rigb.AddForce(Vector3.up * force/5);
                rigb.useGravity = false;
                if (right == true)
                {
                    rigb.AddForce(Vector3.right * force);
                }
                if (left == true)
                {
                    rigb.AddForce(Vector3.left * force);
                }
                if (forward == true)
                {
                    rigb.AddForce(Vector3.forward * force);
                }
                if (back == true)
                {
                    rigb.AddForce(Vector3.back * force);
                }          
                triggered = true;
            }
                
        }
    }
}
