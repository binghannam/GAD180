using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombDropDestroy : MonoBehaviour
{
    
    Rigidbody2D rb2dB;
    public float dropForce;
    GameObject camera1;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void Awake()
    {
        camera1 = GameObject.FindGameObjectWithTag("MainCamera");
    }
    // Update is called once per frame
    void Update()
    {
        rb2dB = GetComponent<Rigidbody2D>();
    }

    private void OnDestroy()
    {
        
        Debug.Log(" cSh.ShakeCam(camera1);");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (camera1 != null) { camera1.GetComponent<CameraShake>().ShakeCam(camera1); }
        Destroy(this.gameObject);
        

    }

    
}
