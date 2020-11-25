using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelScript : MonoBehaviour
{
    public float rotSpeed;
    public float rot;
    public GameObject WheelF;
    public GameObject WheelB;



    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            WheelB.transform.Rotate(-rotSpeed * Time.deltaTime, 0, 0);
            WheelF.transform.Rotate(-rotSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            WheelB.transform.Rotate(rotSpeed * Time.deltaTime, 0, 0);
            WheelF.transform.Rotate(rotSpeed * Time.deltaTime, 0, 0);
        }

        
        

    }
}
