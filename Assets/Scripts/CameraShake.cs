using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public TankShooting shoot;
    public GameObject Cam;
    private Animator anim;

    private void Start()
    {
        anim = Cam.GetComponent<Animator>();
    }
    void Update()
    {
       if(Input.GetKeyDown(shoot.Shoot))
       {
            ShakeCam();
       }
    }

    public void ShakeCam()
    {
        anim.SetTrigger("shootShake");
    }
}
