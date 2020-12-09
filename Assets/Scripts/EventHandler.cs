using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EventHandler : MonoBehaviour
{
    public CollisionDetection CheckTank1;
    public CollisionDetection CheckTank2;

    public GameObject fight;
    public GameObject PlayAgainTxt;
    public GameObject WinnerEvent;

    public Text WinnerText;
    public string winner;

    public bool WinnerisDeclared = false;

    void Update()
    {
        if(CheckTank1.Destroyed == true)
        {
            Player1Died();
        }
        if (CheckTank2.Destroyed == true)
        {
            Player2Died();
        }
        if(WinnerisDeclared == true && Input.GetKeyDown(KeyCode.Space))
        {
            PlayAgain();
            UnFreezeTime();
        }
        
    }
    public void Player1Died()
    {
        WinnerisDeclared = true;
        winner = "Player 2 Wins !";
        UiWinner();
        DisplayWinner();
        FreezeTime();
    }
    public void Player2Died()
    {
        WinnerisDeclared = true;
        winner = "Player 1 Wins !";
        UiWinner();
        DisplayWinner();
        FreezeTime();
    }
    public void DisplayWinner()
    {
        WinnerText.text = winner;
        PlayAgainTxt.SetActive(true);
    }
    public void RaceWin()
    {
        winner = "GG";
        DisplayWinner();
        FreezeTime();
        UiWinner();
    }
    void UiWinner()
    {
        fight.SetActive(false);
        WinnerEvent.SetActive(true);
    }
    void FreezeTime()
    {           
        Time.timeScale = 0f;
    }
    void UnFreezeTime()
    {
        Time.timeScale = 1f;
    }
    void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
