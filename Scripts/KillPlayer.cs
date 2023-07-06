using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public float life;
    public AudioSource deathPlayer;

    void Awake()
    {
       
        Destroy(gameObject, life);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
            deathPlayer.enabled = true;
            SceneManager.LoadScene("GameOverScreen");

        }
    }
    }
