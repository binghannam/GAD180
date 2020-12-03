using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject turn;
    public AudioSFX AudioScript;


    private void Awake()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
                
            }
        }
    }
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        turn.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        

    }
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        turn.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
