using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class showPlayerName : MonoBehaviour
{

    public Text showName;
    public Text showPlayerTime;
    public void Start()
    {
        showName.text = keepData.playerName;
    }



}
