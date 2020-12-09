using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] CameraShake cSh;
    Rigidbody2D rb2dB;
    public float shootForce;

    void Start()
    {
        rb2dB = GetComponent<Rigidbody2D>();
        rb2dB.AddForce(transform.forward * shootForce);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        Destroy(this.gameObject);
        cSh.ShakeCam();
    }
}

        
