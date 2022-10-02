using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class Sword : MonoBehaviour
{
    public OVRInput.Button menu = OVRInput.Button.SecondaryIndexTrigger;
    private bool activity;
    public GameObject obj;
    void Start()
    {
        activity = false;
    }
 
    void Update()
    {
        obj.SetActive(activity);
        if(OVRInput.Get(menu))
        {
            activity = true;
        }
        else
        {
            activity = false;
        }
    }
}

