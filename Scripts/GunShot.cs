using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    public AudioSource gunShot;

    public void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            gunShot.enabled = true;
        }
        else
        {
            gunShot.enabled = false;
        }
    }
}
