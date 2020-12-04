using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour
{
    public Color MaxColor;
    public Color LowColor;

    public Text HealthText;
    public Image HpImage;
    public GameObject Tank;
    public GameObject Explosion;
    public Slider HpBar;

    public AudioSource hit;

    public int hp = 100;
    public bool collided = false;
    public bool Destroyed = false;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            ReduceHp();
            DisplayHp();
            hit.Play();
        }     
    }
    public void ReduceHp()
    {
        hp -= 10;
        collided = false;
    }
    public void DisplayHp()
    {
        HealthText.text = hp.ToString();
        HpImage.color = Color.Lerp(LowColor, MaxColor, hp / 100f);
    }
    public void Update()
    {
        if(hp <= 0)
        {
            Explosion.SetActive(true);
            Destroyed = true;
            Destroy(Tank.gameObject);
            Destroy(HpBar.gameObject);
        }
    }
}
