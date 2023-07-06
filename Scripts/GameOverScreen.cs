using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public KillCountScript killCount;

    void Start()
    {
        killCount = GameObject.Find("KCO").GetComponent<KillCountScript>();
        killCount.ShowKills();
    }
}
