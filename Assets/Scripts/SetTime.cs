using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetTime : MonoBehaviour
{
    public float gameTime = 1;

    public void SetGameTime(float ch)
    {
        gameTime = ch * 60;
        TimeHolder.ch = gameTime;
        SceneManager.LoadScene(1);
    }
}
