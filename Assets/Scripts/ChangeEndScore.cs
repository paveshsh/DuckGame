using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeEndScore : MonoBehaviour
{
    public Text txt1;
    public Text txt2;

    void Start()
    {
        txt1.text = ScoreHolder.score1.ToString();
        txt2.text = ScoreHolder.score2.ToString();
    }
}
