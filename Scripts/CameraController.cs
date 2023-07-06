using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerMovement player;
    public float sensitivity = 200f;


    private float horizontalRotation;
    private float verticalRotation;

    public FixedJoystick joystick;



    private void Start()
    {

        this.horizontalRotation = this.transform.localEulerAngles.y;
        this.verticalRotation = this.transform.localEulerAngles.x;
    }

    private void Update()
    {
        Look();
        Debug.DrawRay(this.transform.position, this.transform.forward * 2, Color.red);

    }


    private void Look()
    {
        
        float mouseVertical = joystick.Vertical;
        float mouseHorizontal = joystick.Horizontal;

        this.horizontalRotation += mouseHorizontal * this.sensitivity * Time.deltaTime;
        this.verticalRotation += mouseVertical * this.sensitivity * Time.deltaTime;

        this.player.transform.rotation = Quaternion.Euler(this.verticalRotation, 0f, 0f);
        this.player.transform.rotation = Quaternion.Euler(0f, this.horizontalRotation, 0f);

    }
}
