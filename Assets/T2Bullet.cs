using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T2Bullet : MonoBehaviour
{
    
    public static T2Bullet instance;
    Rigidbody2D rb2dB;
    public int powerMultiplier = 1;
    public bool Player1Hit = false;

    public GameObject barrelPos;
    public GameObject Bar;
    public GameObject Tank1;


    private float minShootForce = 10;
    public float shootForce;

    public Color MaxColor;
    public Color LowColor;
    public Text HealthText;
    public Image Hp;
    public int value;
    public int newValue;




    [SerializeField] private Transform pfBullet;
    [SerializeField] private tankMovement tankScriptObj;

    void Start()
    {

        rb2dB = GetComponent<Rigidbody2D>();
        pfBullet.Rotate(-16.6f, 348.8f, 66.5f);
        rb2dB.AddForce(transform.forward * shootForce * powerMultiplier);


    }

    private void Update()
    {
        if(value <= 0)
        {
            Destroy(Tank1.gameObject);
        }
    }
    private void TankShootArtillery()
    {
        powerMultiplier++;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);

        if(collision.gameObject.tag == "Player1")
        {
            HpBar();
            
        }
       
    }
    public void HpBar()
    {
        
        Debug.Log("isworkin");

        value --;
        
        HealthText.text = value.ToString();

        Hp.color = Color.Lerp(LowColor, MaxColor, value);

    }

}

