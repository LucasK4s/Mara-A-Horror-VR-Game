using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLight : MonoBehaviour
{
    new Light light;
    public int frames = 0; //count of frames
    public float lg_int = 0; //light intensity
    public float light_start = 0; //value of light intensity at the beginnig
    public List<float> intensStart = new List<float>();
    public bool loaded = false;
    public List<GameObject> _listOfLights;
    private bool triggered = false;
    private bool change;
    private float timeLeft = 100f;
    public Material material;

    // Update is called once per frame
    void Update()
    {
        if (triggered == true && timeLeft > 0)
        {

            //Debug.Log("trigger true");
            foreach (GameObject dropLight in _listOfLights)
            {

                GameObject dropLightChild;
                for (int j = 0; j <= 1; j++)
                {
                    //Debug.Log("search for childs");
                    dropLightChild = dropLight.transform.GetChild(j).gameObject;
                    //Debug.Log(dropLightChild.name);
                    light = dropLightChild.GetComponent<Light>();
                    if (intensStart.Count < 2)
                    {
                        intensStart.Add(light.intensity);
                    }

                    //Debug.Log(light.intensity+" "+dropLightChild.name);
                    //Debug.Log(change);

                    if (light.intensity >= 0f && change == true)
                    {
                        light.intensity += intensStart[j] / 40;
                        if (light.intensity >= intensStart[j])
                        {
                            light.intensity = intensStart[j];
                            material.EnableKeyword("_EMISSION");
                            change = false;
                        }
                        timeLeft -= Time.deltaTime;
                    }
                    if (light.intensity <= intensStart[j] && change == false)
                    {

                        light.intensity -= intensStart[j] / 40;
                        if (light.intensity <= (intensStart[j] / 40))
                        {
                            light.intensity = 0f;
                            material.DisableKeyword("_EMISSION");
                            change = true;
                        }
                        timeLeft -= Time.deltaTime;
                    }

                }
            }
        }
        else
        {
            ShutOff();
        }
        //Debug.Log(timeLeft);
    }

    void ShutOff()
    {
        foreach (GameObject dropLight in _listOfLights)
        {
            GameObject dropLightChild;
            for (int j = 0; j <= 1; j++)
            {
                Debug.Log("search for childs");
                dropLightChild = dropLight.transform.GetChild(j).gameObject;
                Debug.Log(dropLightChild.name);
                light = dropLightChild.GetComponent<Light>();
                light.intensity = 0f;
            }
        }

    }

    IEnumerator Wait(float sec)
    {
        yield return new WaitForSecondsRealtime(sec);
    }

    private void LateUpdate()
    {
        if (Manager.Instance.eleventhTrigger == true && triggered == false)
        {
            _listOfLights = new List<GameObject>(GetComponent<FindLights>().allLights);
            triggered = true;
        }
    }

    /*
      muss gemacht werden
            _listOfLights = new List<GameObject>(GetComponent<FindLights>().allLights);
            triggered = true;
     */
}
