using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

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
    public UnityEvent WinbyRace;

    public int hp = 100;
    public bool Destroyed = false;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            ReduceHpBullet();
            DisplayHp();
            hit.Play();
        }
        if (collision.gameObject.tag == "HPDrop")
        {
            IncreaseHp();
            DisplayHp();
        }
        if (collision.gameObject.tag == "spike")
        {
            ReduceHpSpike();
            DisplayHp();
        }
        if (collision.gameObject.tag == "Crystal")
        {
            WinbyRace.Invoke();
        }
    }
    public void ReduceHpBullet()
    {
        hp -= 10;
    }
    public void IncreaseHp()
    {
        hp += 20;
    }
    public void ReduceHpSpike()
    {
        hp -= 5;
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
