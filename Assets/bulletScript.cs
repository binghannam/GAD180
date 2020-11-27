using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    private bool shoot = false;
    public float shotSpeed;
    public float rotSpeed;
    Rigidbody2D rb2dB;
    public GameObject bullet;
    private bool upB;
    private bool downB;

    void Start()
    {
        rb2dB = GetComponent < Rigidbody2D >();
        bullet.SetActive(false);
       
    }

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Space))
        {   
            shoot = true;      
        }

        if (Input.GetKey(KeyCode.W))
        {
            upB = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            downB = true;
        }
    }
    private void FixedUpdate()
    {
        if(shoot == true)
        {
            rb2dB.velocity = new Vector2(shotSpeed * 1, rb2dB.velocity.y);

        }
        if (upB == true)
        {

            this.transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
            upB = false;

        }

        if (downB == true)
        {

            this.transform.Rotate(0, 0, -rotSpeed * Time.deltaTime);
            downB = false;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(bullet);

        }

    }



}
