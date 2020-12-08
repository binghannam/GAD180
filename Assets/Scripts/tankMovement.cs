using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public KeyCode Right;
    public KeyCode Left;
    public KeyCode Up;
    public KeyCode Down;

    public GameObject Barrel;
    public GameObject WheelF;
    public GameObject WheelB;

    public float sideForceSpeed;
    public float barrelRotSpeed;
    public float WheelrotSpeed;

    private Rigidbody2D rb2d;

    private float rot;

    private bool LSideForce = false;
    private bool RSideForce = false;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(Right))
        {
            RSideForce = true;
            WheelB.transform.Rotate(WheelrotSpeed * Time.deltaTime, 0, 0);
            WheelF.transform.Rotate(WheelrotSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(Left))
        {
            LSideForce = true;
            WheelB.transform.Rotate(-WheelrotSpeed * Time.deltaTime, 0, 0);
            WheelF.transform.Rotate(-WheelrotSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(Up))
        {
            rot -= Time.deltaTime * barrelRotSpeed;
        }
        if (Input.GetKey(Down))
        {
            rot += Time.deltaTime * barrelRotSpeed;
        }
        rot = Mathf.Clamp(rot, 325, 380);
        Barrel.transform.eulerAngles = new Vector3(rot, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
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
