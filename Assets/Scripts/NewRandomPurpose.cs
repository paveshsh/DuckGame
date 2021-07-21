using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewRandomPurpose : MonoBehaviour
{
    public Text NewPurpose;
    public int intNewPurpose;
    public bool flag;
    void Start()
    {
        intNewPurpose = Random.Range(0, 10);
        NewPurpose.text = intNewPurpose.ToString();
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == false)
        {
            flag = true;
            intNewPurpose = Random.Range(0, 10);
            NewPurpose.text = intNewPurpose.ToString();
        }
    }
}
