using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float sideForceSpeed;
    private bool LSideForce = false;
    private bool RSideForce = false;
    private Rigidbody2D rb2d;
    public bool shoot;


    // Artillery firing variables
    public GameObject artilleryBullet;
    Rigidbody artilleryRB;
    public Transform shotPos;
    public GameObject shells;
    public float firePower;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            RSideForce = true;

        }
        if (Input.GetKey(KeyCode.A))
        {
            LSideForce = true;

        }
        if (Input.GetKeyDown(KeyCode.Space))
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
            rb2d.velocity = new Vector2(-1,0);
            shoot = false;
        }
    }


    public void FireArtillery()
    {
        shotPos.rotation = transform.rotation;
        firePower *= 2000;
        GameObject artilleryCopy = Instantiate(artilleryBullet, shotPos.position, shotPos.rotation) as GameObject;
        artilleryRB = artilleryCopy.GetComponent<Rigidbody>();
        artilleryRB.AddForce(transform.forward * firePower);
        Instantiate(shells, shotPos.position, shotPos.rotation);
    }  


}
