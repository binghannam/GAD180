using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public AudioSource backgroundMusic;
    void Start()
    {
        backgroundMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        backgroundMusic.Stop();
        SceneManager.LoadScene(1);
    }
    public void QuitApp()
    {
        Application.Quit();
    }
}
