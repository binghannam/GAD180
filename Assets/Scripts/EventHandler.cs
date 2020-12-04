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
    private string winner;

    public bool WinnerisDeclared = false;

    void Update()
    {
        if(CheckTank1.Destroyed == true)
        {
            WinnerisDeclared = true;
            winner = "Player 2 Wins !";
            UiWinner();
            DisplayWinner();
            FreezeTime();
        }
        if (CheckTank2.Destroyed == true)
        {
            WinnerisDeclared = true;
            winner = "Player 1 Wins !";
            UiWinner();
            DisplayWinner();
            StartCoroutine(FreezeTime());
        }
        if(WinnerisDeclared == true && Input.GetKeyDown(KeyCode.Space))
        {
            PlayAgain();
            UnFreezeTime();
        }
        
    }
    public void DisplayWinner()
    {
        WinnerText.text = winner;
        PlayAgainTxt.SetActive(true);
    }
    void UiWinner()
    {
        fight.SetActive(false);
        WinnerEvent.SetActive(true);
    }
    IEnumerator FreezeTime()
    {
        yield return new WaitForSeconds(3);     
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
