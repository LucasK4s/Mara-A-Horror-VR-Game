using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        //Nothing happens here
    }

    // Update is called once per frame
    void Update()
    {
        //Assign the parents position to the GameObject this script is applied to
        Vector3 position = parent.GetComponent<Transform>().position;
        gameObject.transform.position = position;
    }
}
