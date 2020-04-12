using System.Collections;
using System.Collections.Generic;
using UnityEditor.EventSystems;
using UnityEngine;

public class LevitationBooks : MonoBehaviour
{
    Rigidbody rigb;
    public bool right = false;
    public bool left = false;
    public bool forward = true;
    public bool back = false;
    bool triggered = false;
    public float multiplicator = 1.0f;
    public float force = 100;
    public float leviTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Manager.Instance.twelthTrigger == true && triggered == false)
        {
            triggered = true;
            StartCoroutine(coro());
        }

        if (Manager.Instance.eleventhTrigger == true && leviTime >= 0f)
        {
            leviTime -= Time.deltaTime;
        }
        else
        {
            rigb.useGravity = true;
            //enabled = false;
        }
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (!GetComponent<AudioSource>().isPlaying && collision.relativeVelocity.magnitude >= 1)
        {
            GetComponent<AudioSource>().volume = collision.relativeVelocity.magnitude / 5;
            GetComponent<AudioSource>().Play();
        }
    }

    IEnumerator coro()
    {

        yield return new WaitForSeconds(0.4f);

        rigb.AddForce(Vector3.up * force * multiplicator);
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
    }
}
