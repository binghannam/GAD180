using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletScript : MonoBehaviour
{
    private bool shoot = false;
    public float shotSpeed;
    public float rotSpeed;
    Rigidbody2D rb2dB;
    public GameObject bullet;
    private bool upB;
    private bool downB;
    public Text EnemyHP;
    public int HpReduction = 25;

    void Start()
    {
        rb2dB = GetComponent < Rigidbody2D >();

       
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
            rb2dB.gravityScale = 0.01f;

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
            EnemyHP.text = "HP: " + (100 - HpReduction);
            EnemyHP.color = new Color (255, 181, 0, 255);

        }

    }



}
