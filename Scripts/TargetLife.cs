using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetLife : MonoBehaviour
{
    public PlayerMovement player;
    public AudioSource playerDeath;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerDeath.enabled = true;
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOverScreen");

        }
    }

}
