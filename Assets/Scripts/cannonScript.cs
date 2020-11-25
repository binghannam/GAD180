using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonScript : MonoBehaviour
{
    public float rotSpeed;
    public float rot;


    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rot -= Time.deltaTime * rotSpeed;

        }

        if (Input.GetKey(KeyCode.S))
        {
            rot += Time.deltaTime * rotSpeed;
        }
        
        rot = Mathf.Clamp(rot, 325, 360);
        this.transform.eulerAngles = new Vector3(rot, this.transform.eulerAngles.y, this.transform.eulerAngles.z);

    }

   
}



       
     


   
