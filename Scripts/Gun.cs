using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    public PlayerMovement playermove;

    
    private Button buttonComponent;

    private void Awake()
    {
        buttonComponent = GetComponent<Button>();

    }

    public void OnButtonClicked()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        buttonComponent.onClick.AddListener(OnButtonClicked);
       
    }

}
