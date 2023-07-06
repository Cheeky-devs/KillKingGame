using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public int maxHealth;
    public int curHealth;

    void Start()
    {
        maxHealth = 1;
        curHealth = maxHealth;

    }
    void Update()
    {
        if (curHealth < 1)
        {
            Destroy(gameObject, 2f);
            GetComponent<Animation>().Play("Die");
        }
    }
}
