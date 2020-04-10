using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortraitTrigger : MonoBehaviour
{
    Rigidbody rigb;
    public GameObject disturbedPortrait;
    public GameObject glasSplinters;

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

    private void Update()
    {
        if (Manager.Instance.eighthTrigger == true && Manager.Instance.ninthTrigger == false)
        {
            rigb.isKinematic = false;
            rigb.useGravity = true;

            rigb.AddForce(sign * Vector3.left * force);

            Manager.Instance.ninthTrigger = true;
            glasSplinters.SetActive(true);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor_Collider")
        {
            GetComponent<AudioSource>().Play();
            StartCoroutine(ExampleCoroutine());
        }
    }

    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(1.2f);
        
        gameObject.SetActive(false);
        disturbedPortrait.transform.position = this.transform.position;
        disturbedPortrait.transform.rotation = this.transform.rotation;
        disturbedPortrait.SetActive(true);

    }

}
