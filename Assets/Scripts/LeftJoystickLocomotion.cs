using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class LeftJoystickLocomotion : MonoBehaviour
{
    public Rigidbody player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //var ray = new Ray(this.transform.position, this.transform.forward);
        //Physics.Raycast(ray);
    }

    // Update is called once per frame
    void Update()
    {
        var joystickAxis = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick, OVRInput.Controller.LTouch);
        float fixedY = player.position.y;

        player.position += (transform.right * joystickAxis.x + transform.forward * joystickAxis.y) * Time.deltaTime * speed;
        player.position = new Vector3(player.position.x, fixedY, player.position.z);    
    }
}