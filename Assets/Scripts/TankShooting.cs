using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankShooting : MonoBehaviour
{
    public int hp = 100;
    public float Recoil;

    public KeyCode Shoot;

    private bool shoot = false;

    public GameObject artilleryBullet;
    public Transform shotPos;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(Shoot))
        {
            shoot = true;
        }
    }
    private void FixedUpdate()
    {
        if(shoot == true)
        {
            FireArtillery();
        }
    }
    public void FireArtillery()
    {
        GameObject pfBulletCopy = Instantiate(artilleryBullet, shotPos.position, shotPos.rotation);       
        rb2d.velocity = new Vector2(Recoil, 6);
        shoot = false;
    }
}
