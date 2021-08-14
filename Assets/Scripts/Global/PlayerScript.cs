using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    public static GameObject SpellBookUI;

    void Start()
    {
        animator = this.GetComponent<Animator>();

        if (Progress.playerCharacter == "English")
            animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("Animation/Character1Animation", typeof(RuntimeAnimatorController));

        else if (Progress.playerCharacter == "Japanese")
            animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("Animation/Character2Animation", typeof(RuntimeAnimatorController));

        else if (Progress.playerCharacter == "North African")
            animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("Animation/Character3Animation", typeof(RuntimeAnimatorController));

        else if (Progress.playerCharacter == "South African")
            animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("Animation/Character4Animation", typeof(RuntimeAnimatorController));

        SpellBookUI = GameObject.Find("SpellBookUI");
        SpellBookUI.SetActive(false);



    }

    // movement
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);



    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
    public void LoadSpellBookUI()
    {
        if (SpellBookUI.activeSelf)
        {
            SpellBookUI.SetActive(false);
        }
        else
        {
            SpellBookUI.SetActive(true);
        }
    }


}


