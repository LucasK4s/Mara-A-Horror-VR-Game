using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public Transform target;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        rb.MovePosition(target.transform.position);
        rb.MoveRotation(target.transform.rotation);
    }
}
