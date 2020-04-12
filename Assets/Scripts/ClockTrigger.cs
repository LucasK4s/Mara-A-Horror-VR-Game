using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTrigger : MonoBehaviour
{
    private Clock sc;
    // Start is called before the first frame update
    void Start()
    {
        sc = gameObject.GetComponent<Clock>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Manager.Instance.sixthTrigger == true && Manager.Instance.lightsOut == false)
        {

            if (sc.seconds ==35  ) GetComponent<AudioSource>().Play();
            if (sc.negative == false) sc.negative = true;
            sc.hour = 6;
            float rotationHours = ((360.0f / 12.0f) * sc.hour);
            sc.pointerHours.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationHours);
            float rotationSeconds = (360.0f / 60.0f) * sc.seconds;
            sc.pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationSeconds);
        }
        
    }
    

    
}
