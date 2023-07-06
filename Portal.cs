using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform target, destination;
    public GameObject Target;
    public AudioSource portalSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            Target.SetActive(false);
            portalSound.enabled = false;
            target.position = destination.position;
            Target.SetActive(true);
            portalSound.enabled = true;
        }
    }
}
