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
        if (Manager.Instance.fourthTrigger == true)
        {
            if (sc.minutes != 30)
            {
                StartCoroutine(ExampleCoroutine());
            }
            float rotationHours = ((360.0f / 12.0f) * sc.hour);
            sc.pointerHours.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationHours);
        }
    }

    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.1f);
        sc.minutes = 30;
        sc.hour = 6;

    }
}
