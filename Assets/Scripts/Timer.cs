using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    Image TimerBar;
    public float secTime;
    public float timeLeft;
    public bool startFlag = true;
    public Gun G;

    void Start()
    {
        secTime = TimeHolder.ch;
        TimerBar = GetComponent<Image>();
        timeLeft = secTime;
    }

    void Update()
    {
        if (timeLeft > 0 && startFlag == true)
        {
            timeLeft -= Time.deltaTime;
            TimerBar.fillAmount = timeLeft / secTime;
        }
        else
        {
            ScoreHolder.score1 = G.GetComponent<Gun>().score;
            ScoreHolder.score2 = G.GetComponent<Gun>().score2;
            SceneManager.LoadScene(2);
        }
    }
}