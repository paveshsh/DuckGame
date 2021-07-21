using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayNumbs : MonoBehaviour
{
    public int[] arr;
    public int n;

    void Start()
    {
        arr = new int[10];
        MakeArrayFull();
        n = 10;
    }

    
    void Update()
    {
        if (n==0)
        {
            MakeArrayFull();
            n = 10;
        }
    }

    void MakeArrayFull()
    {
        for (int i=0; i<10; i++)
        {
            //Debug.Log(i);
            arr[i] = i;
        }
    }
}
