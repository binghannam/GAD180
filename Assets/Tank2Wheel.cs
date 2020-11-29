using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank2Wheel : MonoBehaviour
{
    public float rotSpeed;
    public float rot;
    public GameObject WheelF;
    public GameObject WheelB;



    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            WheelB.transform.Rotate(rotSpeed * Time.deltaTime, 0, 0);
            WheelF.transform.Rotate(rotSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            WheelB.transform.Rotate(-rotSpeed * Time.deltaTime, 0, 0);
            WheelF.transform.Rotate(-rotSpeed * Time.deltaTime, 0, 0);
        }




    }
}
