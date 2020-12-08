using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionScript : MonoBehaviour
{
    public GameObject tank;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += tank.transform.position;  
    }
}
