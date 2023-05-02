using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countDownTimer : MonoBehaviour
{

    public Text countDown;
    private float startTime;
    public static float mainTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = keepData.timeLimitRemaining;
        countDown.text = startTime.ToString();
        mainTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        mainTime -= Time.deltaTime;
        if (mainTime > 0)
        {
            countDown.text = "time: " + mainTime.ToString("F2") + " seconds.";
        }
        else
        {
            SceneManager.LoadScene("3Exit");
        }
    }
}