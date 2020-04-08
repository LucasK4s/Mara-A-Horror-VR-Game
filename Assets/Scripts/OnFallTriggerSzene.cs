using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnFallTriggerSzene : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame

    public void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("FadeScene");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene("Apartment");
    }
}
