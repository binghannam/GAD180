using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] CameraShake cSh;
    Rigidbody2D rb2dB;
    public float shootForce;
    public GameObject camera1;

    private void Awake()
    {
        camera1 = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void Start()
    {
        
        rb2dB = GetComponent<Rigidbody2D>();
        rb2dB.AddForce(transform.forward * shootForce);
   
    }
    private void OnDestroy()
    {

        Debug.Log(" cSh.ShakeCam(camera1);");
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(this.gameObject);
       
    }
}

        
