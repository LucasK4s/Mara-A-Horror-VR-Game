using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortraitTrigger : MonoBehaviour
{
    Rigidbody rigb;
    public GameObject disturbedPortrait;
    public GameObject glasSplinters;
    public GameObject note12;
    AudioSource audio1;
    AudioSource audio2;
    public float force = 50f;
    public bool forceNegative = false;
    private float sign = 1;
    bool secondCol = false;
    
    void Start()
    {
        AudioSource[] audios = GetComponents<AudioSource>();
        audio1 = audios[0];
        audio2 = audios[1];
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
            audio2.Play();

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        
            if (!audio2.isPlaying && collision.relativeVelocity.magnitude >= 1 && secondCol== true)
            {
                GetComponent<AudioSource>().volume = collision.relativeVelocity.magnitude / 10;
                GetComponent<AudioSource>().Play();
            }
        secondCol = true;
        
    }

    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(1.2f);
        note12.SetActive(true);
        gameObject.SetActive(false);
        disturbedPortrait.transform.position = this.transform.position;
        disturbedPortrait.transform.rotation = this.transform.rotation;
        disturbedPortrait.SetActive(true);

    }

}
