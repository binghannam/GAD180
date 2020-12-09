using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombDropDestroy : MonoBehaviour
{
    CameraShake cSh;
    Rigidbody2D rb2dB;
    public float dropForce;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        rb2dB = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        cSh.ShakeCam();
        Destroy(this.gameObject);
        

    }
}
