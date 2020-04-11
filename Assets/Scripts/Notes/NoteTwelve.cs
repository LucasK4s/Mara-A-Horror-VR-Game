using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTwelve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    public void PickUp()
    {
        GetComponent<AudioSource>().Play();
    }

    public void PutAway()
    {
        GameObject.Find("AS12").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteTwelve = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
