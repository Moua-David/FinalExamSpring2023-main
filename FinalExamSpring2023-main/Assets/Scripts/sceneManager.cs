using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    public void startGame()
    {
        SceneManager.LoadScene("2Game");
    }

    public void exit()
    {
        SceneManager.LoadScene("3Exit");
    }

    public void replay()
    {
        SceneManager.LoadScene("2Game");
    }

    public void quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}