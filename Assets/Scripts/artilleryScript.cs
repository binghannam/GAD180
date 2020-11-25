using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class artilleryScript : MonoBehaviour
{
    public float lifeTime = 5f;
    public GameObject explosion;
    public float minY = -20f;

    
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void StatusCheck()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime < 0)
        {
            // Instantia and destroy the artillery
            Destroy();
        }

        // check transform position y
        if (transform.position.y < minY)
        {
            // destroy function
            Destroy();
        }
    }

    private void Destroy()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
