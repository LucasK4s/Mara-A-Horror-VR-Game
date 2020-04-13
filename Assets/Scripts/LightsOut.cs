using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LightsOut : MonoBehaviour
{
    public GameObject bedlight1;
    public GameObject bedlight2;
    public GameObject tableLamp;
    public GameObject laptop;
    public GameObject canvas;
    public GameObject logo;
    public GameObject[] lights;
    bool trig;
    public GameObject[] audiosources;
    // Start is called before the first frame update
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("Fire");
        audiosources = GameObject.FindGameObjectsWithTag("Audio");
    }

    // Update is called once per frame
    void Update()
    {
        if(Manager.Instance.lightsOut == true && trig == false)
        {
            trig = true;
            foreach (GameObject i in lights)
            {
                i.SetActive(false);
            }

            bedlight1.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            bedlight2.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            tableLamp.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            laptop.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            RenderSettings.ambientLight = Color.black;
            

            StartCoroutine(Coro());

        }
    }
    IEnumerator Coro()
    {
        yield return new WaitForSeconds(0.8f);
        canvas.SetActive(true);
        GameObject.Find("WhisperAmbient").GetComponent<AudioSource>().Stop();
        foreach (GameObject i in audiosources)
        {
            i.GetComponent<AudioSource>().Stop();
        }
        GameObject.Find("HeartBeat").GetComponent<AudioSource>().Stop();

        StartCoroutine(Coro2());
    }

    IEnumerator Coro2()
    {
        yield return new WaitForSeconds(3);
        logo.SetActive(true);
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("Main Menu");
    }
}
