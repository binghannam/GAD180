using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank2Movement : MonoBehaviour
{
    public float sideForceSpeed;
    private bool LSideForce = false;
    private bool RSideForce = false;
    private Rigidbody2D rb2d;


    // Artillery firing variables
    public GameObject artilleryBullet;
    public Transform shotPos;
    private bool shoot = false;

    public int artilleryLeft;
    public int spacebarForce;

    [SerializeField] private Transform pfBullet;
    [SerializeField] public bulletScript bulletScriptMini;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        artilleryLeft = -1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            RSideForce = true;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            LSideForce = true;

        }

        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            shoot = true;
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
        if (shoot == true)
        {
            FireArtillery();
            shoot = false;
        }
    }


    public void FireArtillery()
    {


        if (artilleryLeft < 0)
        {
            GameObject pfBulletCopy = Instantiate(artilleryBullet, shotPos.position, shotPos.rotation);

            rb2d.velocity = new Vector2(1, 0);

        }

    }



    /* private void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.name == "Bullet(Clone)")
         {
             Destroy(this.gameObject);
         }
     }*/



}
