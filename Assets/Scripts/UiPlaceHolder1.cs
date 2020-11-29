using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiPlaceHolder1 : MonoBehaviour
{
    public Slider hp;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        hp.transform.position = namePos;
               
    }
}
