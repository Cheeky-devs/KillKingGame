using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillCountScript : MonoBehaviour
{
    public static KillCountScript killCount;
    public Text counterText;
    public Text KillPoints;
    int kills;
    int killsPoint;
    
    
    // Start is called before the first frame update
    private void Awake()
    {
        if (killCount == null)
        {
                killCount = this;
                //DontDestroyOnLoad(gameObject);
           

        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ShowKills();
    }

    public void ShowKills()
    {
        counterText.text = kills.ToString();
        KillPoints.text = killsPoint.ToString();
    }
    public void AddKill()
    {
        kills++;
        killsPoint += 100;
    }
}
