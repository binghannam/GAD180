using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleCheck : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public EventHandler rip;

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player1")
        {
            rip.Player1Died();
        }
        if (collision.gameObject.tag == "Player2")
        {
            rip.Player2Died();
        }
    }
 
}
