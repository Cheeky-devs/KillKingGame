using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootButton : MonoBehaviour
{

    public Animator anim;
    public bool shoot;
    private Button buttonComponent;
    public Rigidbody rb;

    private void Awake()
    {
        buttonComponent = GetComponent<Button>();

    }

    public void OnButtonClicked()
    {
        this.anim.SetBool("shoot", !this.shoot);
        buttonComponent.onClick.AddListener(OnButtonClicked);
    }
    public void OnButtonNotClicked()
    {

        this.anim.SetBool("shoot", this.shoot);
        buttonComponent.onClick.AddListener(OnButtonNotClicked);
    }
}
