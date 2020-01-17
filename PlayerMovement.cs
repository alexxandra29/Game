using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    //bool crouch = false;
    // Update is called once per frame

    GameManagerScript gm;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
    }
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (Input.GetButtonDown("Jump") && jump == false)
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            runSpeed = 2000;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);jump = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="coin")
        {
            gm.CoinCollected();
            Destroy(other.gameObject);
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        
    }
}
