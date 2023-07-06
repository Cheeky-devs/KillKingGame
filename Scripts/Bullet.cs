using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public AudioSource playerDeath,coins, missleLaunch;
    public KillCountScript killCount;
    public float life;

    void Awake()
    {
        Destroy(gameObject, life);
        killCount = GameObject.Find("KCO").GetComponent<KillCountScript>();
        missleLaunch.enabled = true;
    }
 
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerDeath.enabled = true;
            coins.enabled = true;
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOverScreen");

        }
        if (collision.gameObject.name == "Target")
        {
            playerDeath.enabled = true;
            Destroy(collision.gameObject);
            killCount.AddKill();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (collision.gameObject.name == "Target Army (0)")
        {
            playerDeath.enabled = true;
            Destroy(collision.gameObject);
            killCount.AddKill();
            coins.enabled = true;

        }
        if (collision.gameObject.name == "Target Army (1)")
        {
            playerDeath.enabled = true;
            Destroy(collision.gameObject);
            killCount.AddKill();
            coins.enabled = true;

        }
        if (collision.gameObject.name == "Target Army (2)")
        {
            playerDeath.enabled = true;
            Destroy(collision.gameObject);
            killCount.AddKill();
            coins.enabled = true;

        }
        if (collision.gameObject.name == "Target Army (3)")
        {
            playerDeath.enabled = true;
            Destroy(collision.gameObject);
            killCount.AddKill();
            coins.enabled = true;

        }
        if (collision.gameObject.name == "Target Army (4)")
        {
            playerDeath.enabled = true;
            Destroy(collision.gameObject);
            killCount.AddKill();
            coins.enabled = true;

        }

        if (collision.gameObject.name == "Target Army (5)")
        {
            playerDeath.enabled = true;
            Destroy(collision.gameObject);
            killCount.AddKill();
            coins.enabled = true;

        }


    }
}
