using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewRandomPurpose : MonoBehaviour
{
    public Text NewPurpose;
    public int intNewPurpose;
    public bool flag;
    private int beforeNumb;

    void Start()
    {
        intNewPurpose = Random.Range(0, 10);
        beforeNumb = intNewPurpose;
        NewPurpose.text = intNewPurpose.ToString();
        flag = true;
    }

    void Update()
    {
        if (flag == false)
        {
            flag = true;
            while (intNewPurpose == beforeNumb)
            {
                intNewPurpose = Random.Range(0, 10);
            }
            beforeNumb = intNewPurpose;
            NewPurpose.text = intNewPurpose.ToString();
        }
    }
}
