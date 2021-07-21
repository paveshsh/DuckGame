using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLive : MonoBehaviour
{
    private Animator anime;
    Rigidbody2D duckRigit;
    public bool isActive;
    public int duckNumb;

    private void Start()
    {
        anime = GetComponent<Animator>();
        duckRigit = GetComponent<Rigidbody2D>();
        isActive = true;
    }

    public void ByeDuck()
    {
        anime.SetTrigger("ByeTrigger");
        isActive = false;
        Destroy(gameObject, 1);
    }
}
