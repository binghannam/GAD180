using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake mainCamera;
    public TankShooting shoot;
    public GameObject Cam;
    private Animator anim;

    private void Start()
    {
        mainCamera = this;
        anim = Cam.GetComponent<Animator>();
    }
    void Update()
    {
       if(Input.GetKeyDown(shoot.Shoot))
       {
            ShakeCam(Cam);
       }
    }

    public void ShakeCam(GameObject camera1)
    {
        anim.SetTrigger("shootShake");
    }
}
