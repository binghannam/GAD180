using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour
{
    public Color MaxColor;
    public Color LowColor;
    public Text HealthText;
    public Image Hp;
    public int hp = 100;

    public string bullTag;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            ReduceHp();
            DisplayHp();
        }     
    }
    public void ReduceHp()
    {
        hp -= 10;
    }
    public void DisplayHp()
    {
        HealthText.text = hp.ToString();
        Hp.color = Color.Lerp(LowColor, MaxColor, hp / 100f);
    }
}
