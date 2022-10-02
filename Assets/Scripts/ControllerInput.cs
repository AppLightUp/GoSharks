using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    public Transform Gun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.PrimaryHandTrigger)){
            RayCastGun();
        }
    }

    private void RayCastGun()
    {
        RaycastHit hit;
        if(Physics.Raycast(Gun.position,Gun.forward,out hit))
        {
            if(hit.collider.gameObject.CompareTag("Box"))
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
