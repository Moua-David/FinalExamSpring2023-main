using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{

    [SerializeField] GameObject menuPause;
    public Button resumeButton;
    private bool pauseGame = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    void Pause()
    {
        Time.timeScale = 0f;
        pauseGame = true;
        menuPause.SetActive(true);
        resumeButton.gameObject.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1.0f;
        pauseGame = false;
        menuPause.SetActive(false);
        resumeButton.gameObject.SetActive(false);
    }

    public void print()
    {
        Debug.Log("Saved as JSON");
    }
}
