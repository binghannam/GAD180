using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankMovement : MonoBehaviour
{
    public float sideForceSpeed;
    private bool LSideForce = false;
    private bool RSideForce = false;
    private Rigidbody2D rb2d;
    private bool shoot;
    private Animator anim;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            RSideForce = true;
            anim.SetBool("MovingRight", true);

        }
        else
        {
            anim.SetBool("MovingRight", false);

        }
        if (Input.GetKey(KeyCode.A))
        {
            LSideForce = true;
            anim.SetBool("MovingLeft", true);

        }
        else
        {
            anim.SetBool("MovingLeft", false);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Shoot");
        }
    }

    private void FixedUpdate()
    {
        if (RSideForce == true)
        {
            rb2d.velocity = new Vector2(sideForceSpeed * 1, rb2d.velocity.y);
            RSideForce = false;
        }
        if (LSideForce == true)
        {
            rb2d.velocity = new Vector2(-sideForceSpeed * 1, rb2d.velocity.y);
            LSideForce = false;
        }
        
    }
}
