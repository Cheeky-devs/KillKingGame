using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpButton : MonoBehaviour
{

    public Animator anim;
    public bool jump;
    private Button buttonComponent;
    public Rigidbody rb;

    private void Awake()
    {
        buttonComponent = GetComponent<Button>();

    }

    public void OnButtonClicked()
    {
        this.rb.AddForce(Vector3.up * 4, ForceMode.Impulse);
        this.anim.SetBool("jump", !this.jump);
        buttonComponent.onClick.AddListener(OnButtonClicked);
    }
    public void OnButtonNotClicked()
    {

        this.anim.SetBool("jump", this.jump);
        buttonComponent.onClick.AddListener(OnButtonNotClicked);
    }
}
