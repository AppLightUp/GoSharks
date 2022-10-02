using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Players : MonoBehaviour
{
    // Start is called before the first frame update
    public float health;
    public Slider slide;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slide.value=health;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            if(health==0){
                SceneManager.LoadScene("main menu");
            }
            health=health-10f;
        }
    }
}
