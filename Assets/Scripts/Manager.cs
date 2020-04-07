using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance { get; set; }

    public bool firstTrigger;
    public bool secondTrigger;
    public bool thirdTrigger;
    public bool fourthTrigger;
    public bool fithTrigger;
    public bool sixthTrigger;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }



}
