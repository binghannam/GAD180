using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSFX : MonoBehaviour
{
    public EventHandler Winner;

    public CollisionDetection bulletHit1;
    public CollisionDetection bulletHit2;

    public GameObject tank1;
    public GameObject tank2;

    public AudioSource explosion;
    public AudioSource hit;
    public AudioSource shot;
    public AudioSource BackgroundMusic;
    public AudioSource WinnerSFX;

    private void Start()
    {
        BackgroundMusic.Play();
    }
    void Update()
    {
        if (Input.GetKeyDown(tank1.GetComponent<TankShooting>().Shoot)
                   || Input.GetKeyDown(tank2.GetComponent<TankShooting>().Shoot))
        {
            shot.Play();
        }   
            
        if (bulletHit1.hp <= 0 || bulletHit2.hp <= 0)
        {
            explosion.Play();
            BackgroundMusic.Stop();
            WinnerSFX.Play();
        }     
    }
}
    
