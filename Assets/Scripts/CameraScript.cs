using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float CamSpeed;
    void Update()
    {
        transform.position += new Vector3(0, CamSpeed * Time.deltaTime,0);
    }
}
