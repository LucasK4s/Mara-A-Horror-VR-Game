using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindLights : MonoBehaviour
{
    public GameObject lighting;
    public GameObject dropLight;
    private Light _childOfLight;
    public List<GameObject> allLights = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        allLights = findingLights();          
    }

    public List<GameObject> findingLights()
    {
        List<GameObject> list = new List<GameObject>();
        int children = transform.childCount;
        for (int i = 0; i < children; i++)
        { 
            lighting = transform.GetChild(i).gameObject;
            list.Add(lighting);
        }
        return list;
    }


}
