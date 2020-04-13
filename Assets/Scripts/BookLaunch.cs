using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookLaunch : MonoBehaviour
{
    public GameObject book1;
    public GameObject book2;
    public GameObject book3;
    public GameObject book4;
    public GameObject book5;
    public float force1;
    public float force2;
    public float force3;
    public float force4;
    public float force5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Manager.Instance.NoteEleven == true && Manager.Instance.seventhTrigger == false)
        {
            Manager.Instance.seventhTrigger = true;
            Launch();
        }
    }

    void Launch()
    {
        StartCoroutine(Coro1());
    }

    IEnumerator Coro1()
    {
        yield return new WaitForSeconds(2);
        book1.GetComponent<Rigidbody>().isKinematic = false;
        book1.GetComponent<Rigidbody>().useGravity = true;
        GameObject.Find("seiten1").GetComponent<AudioSource>().Play();
        book1.GetComponent<Rigidbody>().AddForce(Vector3.right * force1);

        StartCoroutine(Coro2());
    }

    IEnumerator Coro2()
    {
        yield return new WaitForSeconds(1);
        book2.GetComponent<Rigidbody>().isKinematic = false;
        book2.GetComponent<Rigidbody>().useGravity = true;
        GameObject.Find("seiten2").GetComponent<AudioSource>().Play();
        book2.GetComponent<Rigidbody>().AddForce(Vector3.right * force2);

        StartCoroutine(Coro3());

    }

    IEnumerator Coro3()
    {
        yield return new WaitForSeconds(2.5f);
        book3.GetComponent<Rigidbody>().isKinematic = false;
        book3.GetComponent<Rigidbody>().useGravity = true;
        GameObject.Find("seiten3").GetComponent<AudioSource>().Play();
        book3.GetComponent<Rigidbody>().AddForce(Vector3.right * force3);


        StartCoroutine(Coro4());

    }

    IEnumerator Coro4()
    {
        yield return new WaitForSeconds(0.1f);
        book4.GetComponent<Rigidbody>().isKinematic = false;
        book4.GetComponent<Rigidbody>().useGravity = true;
        GameObject.Find("seiten4").GetComponent<AudioSource>().Play();
        book4.GetComponent<Rigidbody>().AddForce(Vector3.right * force4);


        StartCoroutine(Coro5());

    }

    IEnumerator Coro5()
    {
        yield return new WaitForSeconds(0.7f);
        book5.GetComponent<Rigidbody>().isKinematic = false;
        book5.GetComponent<Rigidbody>().useGravity = true;
        GameObject.Find("seiten5").GetComponent<AudioSource>().Play();
        book5.GetComponent<Rigidbody>().AddForce(Vector3.right * force5);
        StartCoroutine(Coro6());
    }

    IEnumerator Coro6()
    {
        yield return new WaitForSeconds(8);
        Manager.Instance.eighthTrigger = true;
    }
}
