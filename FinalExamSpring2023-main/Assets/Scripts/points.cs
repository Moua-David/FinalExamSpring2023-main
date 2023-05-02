using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{

    public static int score = 0;
    public Text displayScore;

    public void upScore()
    {
        score++;
        displayScore.text = score.ToString();
    }

    public void downScore()
    {
        score--;
        displayScore.text = score.ToString();
    }


}
