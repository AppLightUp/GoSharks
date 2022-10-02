using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;
using UnityEngine.SceneManagement;
using System.Threading;

public class Collect : MonoBehaviour
{
    public GameObject bus;
    public GameObject pmirror;
    public GameObject si;
    public GameObject smirror;
    public GameObject flap;
    public GameObject sun;
    public GameObject antenna;
    //public Transform gun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bus") {
            Destroy(collision.gameObject);
            bus.SetActive(true);
        }

        if(collision.gameObject.tag == "pmirror") {
            Destroy(collision.gameObject);
            pmirror.SetActive(true);
        }

        if(collision.gameObject.tag == "si") {
            Destroy(collision.gameObject);
            si.SetActive(true);
        }
    
        if(collision.gameObject.tag == "smirror") {
            Destroy(collision.gameObject);
            smirror.SetActive(true);
        }

        if(collision.gameObject.tag == "flap") {
            Destroy(collision.gameObject);
            flap.SetActive(true);
        }

        if(collision.gameObject.tag == "sun") {
            Destroy(collision.gameObject);
            sun.SetActive(true);
        }

        if(collision.gameObject.tag == "antenna") {
            Destroy(collision.gameObject);
            antenna.SetActive(true);
        }

        if(collision.gameObject.tag == "empty") {
            SceneManager.LoadScene("jwstt");
        }
    }
}
