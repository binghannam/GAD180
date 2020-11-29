using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYER1TURN, PLAYER2TURN, WON}

public class BattleSystem : MonoBehaviour
{

    public GameObject Player1Prefab;
    public GameObject Player2Prefab;

    //public bool isDead;
    //public int health;

    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }


    void SetupBattle()
    {

        state = BattleState.PLAYER1TURN;
        Player1Turn();

    }

    void Player1Turn()
    {
        Debug.Log ("Player 1's Turn");

        Player1Prefab.GetComponentInChildren<tankMovement>().enabled = true;
        Player2Prefab.GetComponentInChildren<tankMovement>().enabled = false;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //WaitForSecondsRealtime(3f);

            state = BattleState.PLAYER2TURN;
            Player2Turn();
        }
    }

    void Player2Turn()
    {
        Debug.Log("Player 2's Turn");

        Player1Prefab.GetComponentInChildren<tankMovement>().enabled = false;
        Player2Prefab.GetComponentInChildren<tankMovement>().enabled = true;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            state = BattleState.PLAYER1TURN;
            Player1Turn();
        }

    }

    void Update()
    {
        
        //Check currentHP for both players.
        //If currentHP of one of player1 or player2 is < or = 0,    state = BattleState.WON;   Result();
    }

    void Result()
    {
        //If Player1 currentHP = 0, set Player2 as winningPLayer.
        //If Player2 currentHP = 0, set Player1 as winningPLayer.

        //Debug.Log(winningPlayer + "Wins!");
    }
}





/*
  This below if statement did not work, the 'shoot' boolean was not being recognized. Even though the bool was made public in
the tankMovement script. Instead, if(Input.GetKeyDown(KeyCode.Space)) was used.

        if (shoot = true)
        {

        }
 

IDEAS:
We can create a loop that goes back and forth between the 2 player(turn)s, until the HP of one reaches 0. After which,
Game will end by BattleState.WON;

-If player1 health is 0, set player2 as Winning Player and vice versa.

 */
