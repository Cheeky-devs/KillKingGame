using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSound : MonoBehaviour
{
    public AudioSource portalSound;


   void Awake()
    {
        portalSound.enabled = true;
    }  
}
