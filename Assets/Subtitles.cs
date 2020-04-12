using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "";

        StartCoroutine(Sub());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Sub()
    {
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<Text>().text = "After a long night of researching about a fantasy creature called \"Mare\", you fell asleep on your desk. \n As you wake up, you realize something feels odd..";
        yield return new WaitForSeconds(7);
        gameObject.GetComponent<Text>().text = "";

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<Text>().text = "";
    }

    public void FirstNote()
    {
        gameObject.GetComponent<Text>().text = "\"DEEP SLEEP\" \n It's in your handwriting but you don't remember writing that note..?";
        StartCoroutine(Wait());
    }

    public void SecondNote()
    {
        gameObject.GetComponent<Text>().text = "\"NIGHTMARE\"";
        StartCoroutine(Wait());
    }

    public void ThirdNote()
    {
        gameObject.GetComponent<Text>().text = "\"WAKE UP\"";
        StartCoroutine(Wait());
    }

    public void FourthNote()
    {
        gameObject.GetComponent<Text>().text = "\"KNOCK KNOCK\"";
        StartCoroutine(Wait());
    }

    public void FithNote()
    {
        gameObject.GetComponent<Text>().text = "\"MY HIDING PLACE\"";
        StartCoroutine(Wait());
    }

    public void SixthNote()
    {
        gameObject.GetComponent<Text>().text = "\"NO ONE IS CALLING\"";
        StartCoroutine(Wait());
    }

    public void SeventhNote()
    {
        gameObject.GetComponent<Text>().text = "\"IT'S GETTING LATE\" \n Wait.. what time is it?";
        StartCoroutine(Wait());
    }

    public void EighthNote()
    {
        gameObject.GetComponent<Text>().text = "\"WHAT'S THE TIME\"";
        StartCoroutine(Wait());
    }

    public void NinthNote()
    {
        gameObject.GetComponent<Text>().text = "\"HELL IS NEAR\" in the book shelf?";
        StartCoroutine(Wait());
    }

    public void EleventhNote()
    {
        gameObject.GetComponent<Text>().text = "\"THE GIRL IS DEAD\" ..maybe the Painting?";
        StartCoroutine(Wait());
    }

    public void TwelthNote()
    {
        gameObject.GetComponent<Text>().text = "\"LOOK AT ME\"";
        StartCoroutine(Wait());
    }
}
