using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MuteSound : MonoBehaviour
{
    public void Sound()
    {
        if (AudioListener.volume == 1f)
        {
            
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume = 1f;
        }
    }
}
