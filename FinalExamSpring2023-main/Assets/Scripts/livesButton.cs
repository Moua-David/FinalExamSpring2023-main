using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livesButton : MonoBehaviour
{
    
    public Text livesText;
    public Button decreaseButton;
    public Button increaseButton;

    public static int lives;

    void Start()
    {
        
        lives = PlayerPrefs.GetInt("lives", 4);

        
        livesText.text = "Lives: " + lives.ToString();

        
        decreaseButton.onClick.AddListener(DecreaseLives);
        increaseButton.onClick.AddListener(IncreaseLives);
    }

    void DecreaseLives()
    {
        
        lives--;
        PlayerPrefs.SetInt("lives", lives);
        livesText.text = "Lives: " + lives.ToString();
    }

    void IncreaseLives()
    {
        lives++;
        PlayerPrefs.SetInt("lives", lives);
        livesText.text = "Lives: " + lives.ToString();
    }
}
