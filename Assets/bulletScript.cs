using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    
    private bool shoot = false;
    Rigidbody2D rb;
    Rigidbody2D rb2dB;
    public int shootForce;
    public int powerMultiplier = 1;
    private bool upB;
    private bool downB;
    public float barrelRot;
    public GameObject barrelPos;
    
    [SerializeField] private Transform pfBullet;
    [SerializeField] private tankMovement tankScriptObj;

    void Start()
    {
     
        rb2dB = GetComponent < Rigidbody2D >();
        rb2dB.AddForce(transform.forward * shootForce * powerMultiplier);

    }

    private void Update()
    {
        


    }

    private void TankShootArtillery()
    {

        powerMultiplier++;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);


    }




}
