using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonScript : MonoBehaviour
{
    public float rotSpeed;
    private bool up;
    private bool down;


    void Start()
    {

    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            up = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            down = true;
        }

        
    }

    private void FixedUpdate()
    {
        if(up == true)
        {
           
            this.transform.Rotate(-rotSpeed * Time.deltaTime,0,0);
            up = false;

        }

        if (down == true)
        {
            
            this.transform.Rotate(rotSpeed * Time.deltaTime, 0, 0);
            down = false;

        }
    }


}



       
     


   
