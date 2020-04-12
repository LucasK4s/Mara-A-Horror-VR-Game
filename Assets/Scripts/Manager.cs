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
    public bool seventhTrigger;
    public bool eighthTrigger;
    public bool ninthTrigger;
    public bool tenthTrigger;
    public bool eleventhTrigger;
    public bool twelthTrigger;
    public bool thirteenthTrigger;
    public bool fourteenthTrigger;
    public bool fithteenthTrigger;
    public bool sixteenthTrigger;
    public bool seventeenthTrigger;

    public bool NoteOne;
    public bool NoteTwo;
    public bool NoteThree;
    public bool NoteFour;
    public bool NoteFive;
    public bool NoteSix;
    public bool NoteSeven;
    public bool NoteEight;
    public bool NoteNine;
    public bool NoteTen;
    public bool NoteEleven;
    public bool NoteTwelve;
    public bool NoteThirteen;
    public bool playWhisper;
    public bool playSuspense;



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
