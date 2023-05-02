using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class keepData : MonoBehaviour
{

    public static string playerName;
    public InputField inputPlayerName;

    public Slider slider;
    public static float timeLimitRemaining = 30.0f;
    public Text showTime;

    public void Start()
    {
        timeLimitRemaining = slider.value;
        showTime.text = slider.value.ToString();
        setTime();
    }

    public void Update()
    {
        showTime.text = slider.value.ToString();
    }

    public void setTime()
    {
        timeLimitRemaining = slider.value;
    }


    public void UpdateName()
    {
        playerName = inputPlayerName.text;
    }



}