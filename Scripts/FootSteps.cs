using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioSource footstepSound, sprintSound, jumpSound;
    public AudioSource footstepPant;

    void Update()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footstepSound.enabled = true;
 
        }
        else if (Input.GetKey(KeyCode.W))
        {
            sprintSound.enabled = true;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            jumpSound.enabled = true;
        }
        else
        {
            footstepSound.enabled = false;
            sprintSound.enabled = false;
            jumpSound.enabled = false;
            footstepPant.enabled = true;
        }
    }
}
