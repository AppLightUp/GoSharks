using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class Destroyer : MonoBehaviour
{
    public GameObject currentHitObject;

    public Material defaultMaterial;
    public Material highLightMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,Mathf.Infinity))
        {
            Debug.DrawRay(transform.position,transform.TransformDirection(Vector3.forward)*hit.distance,Color.red);
            var selectedObject = hit.transform;
            if(selectedObject != null)
            {
                Renderer selectedObjectRender = hit.transform.GetComponent<Renderer>();
                //selectedObjectRender.material = highLightMaterial;
                currentHitObject = hit.transform.gameObject;
                /*if(OVRInput.Get(OVRInput.Button.One))
                {
                    selectedObjectRender.material = highLightMaterial;
                }*/
                if(currentHitObject.tag == "alien" && OVRInput.Get(OVRInput.Button.One))
                {
                    Destroy(currentHitObject.gameObject);
                }
                /*if(selectedObject.gameObject.tag == "alien" && OVRInput.Get(OVRInput.Button.One))
                {
                    Destroy(selectedObject.gameObject);
                }*/
            }
        }
        /*else
        {
            Debug.DrawRay(transform.position,transform.TransformDirection(Vector3.forward)*8,Color.blue);
            if(currentHitObject != null)
            {
                Renderer currentHitObjectRender = currentHitObject.transform.GetComponent<Renderer>();
                currentHitObjectRender.material = defaultMaterial;
                currentHitObject = null;
            }
        }*/
        /*if(hit.collider.gameObject.CompareTag("alien"))
        {
            winText.SetActive(true);
            Destroy(hit.collider.gameObject);
        }*/
    }
}
