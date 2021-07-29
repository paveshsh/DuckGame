using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawner : MonoBehaviour
{
    public GameObject DuckType1;
    public GameObject DuckType2;
    public GameObject DuckType3;

    public GameObject Num0;
    public GameObject Num1;
    public GameObject Num2;
    public GameObject Num3;
    public GameObject Num4;
    public GameObject Num5;
    public GameObject Num6;
    public GameObject Num7;
    public GameObject Num8;
    public GameObject Num9;

    public bool[] arr;
    public int ch;
    public int flag;

    void Start()
    {
        flag = 10;
        arr = new bool[10];
        for (int i = 0; i < 10; i++)
        {
            arr[i] = true;
        }
        StartCoroutine(Spawner());
    }


    IEnumerator Spawner()
    {
        while (true)
        {
            int randDuck = Random.Range(0, 100);
            if (randDuck <= 33)
            {
                GameObject newDuck = Instantiate(DuckType1, new Vector3(-11, -1.3f, 0), Quaternion.identity);
                ch = GetNumber();
                newDuck.GetComponent<TargetLive>().duckNumb = ch;
                Destroy(newDuck, 25);
                SpawnerNumbs(ch);
            }
            else if (randDuck <= 66)
            {
                GameObject newDuck = Instantiate(DuckType2, new Vector3(-11, -1.3f, 0), Quaternion.identity);
                ch = GetNumber(); ;
                newDuck.GetComponent<TargetLive>().duckNumb = ch;
                Destroy(newDuck, 25);
                SpawnerNumbs(ch);
            }
            else
            {
                GameObject newDuck = Instantiate(DuckType3, new Vector3(-11, -1.3f, 0), Quaternion.identity);
                ch = GetNumber();
                newDuck.GetComponent<TargetLive>().duckNumb = ch;
                Destroy(newDuck, 25);
                SpawnerNumbs(ch);
            }
            yield return new WaitForSeconds(4);
        }
    }

    void SpawnerNumbs(int ch)
    {
        if (ch == 0)
        {
            GameObject newNum = Instantiate(Num0, new Vector3(-11, 2.5f, 0), Quaternion.identity);
            Destroy(newNum, 25);
        }
        else if (ch == 1)
        {
            GameObject newNum = Instantiate(Num1, new Vector3(-11, 2.5f, 0), Quaternion.identity);
            Destroy(newNum, 25);
        }
        else if (ch == 2)
        {
            GameObject newNum = Instantiate(Num2, new Vector3(-11, 2.5f, 0), Quaternion.identity);
            Destroy(newNum, 25);
        }
        else if (ch == 3)
        {
            GameObject newNum = Instantiate(Num3, new Vector3(-11, 2.5f, 0), Quaternion.identity);
            Destroy(newNum, 25);
        }
        else if (ch == 4)
        {
            GameObject newNum = Instantiate(Num4, new Vector3(-11, 2.5f, 0), Quaternion.identity);
            Destroy(newNum, 25);
        }
        else if(ch == 5)
        {
            GameObject newNum = Instantiate(Num5, new Vector3(-11, 2.5f, 0), Quaternion.identity);
            Destroy(newNum, 25);
        }
        else if (ch == 6)
        {
            GameObject newNum = Instantiate(Num6, new Vector3(-11, 2.5f, 0), Quaternion.identity);
            Destroy(newNum, 25);
        }
        else if (ch == 7)
        {
            GameObject newNum = Instantiate(Num7, new Vector3(-11, 2.5f, 0), Quaternion.identity);
            Destroy(newNum, 25);
        }
        else if (ch == 8)
        {
            GameObject newNum = Instantiate(Num8, new Vector3(-11, 2.5f, 0), Quaternion.identity);
            Destroy(newNum, 25);
        }
        else 
        {
            GameObject newNum = Instantiate(Num9, new Vector3(-11, 2.5f, 0), Quaternion.identity);
            Destroy(newNum, 25);
        }
    }

    int GetNumber()
    {
        if (flag==0)
        {
            flag = 10;
            for (int i = 0; i < 10; i++)
            {
                arr[i] = true;
            }
        }
        int x = Random.Range(0, 10);
        if (arr[x] == true)
        {
            arr[x] = false;
            flag--;
            return x;
        }
        else
        {
            if (x!=0 && arr[x-1]==true)
            {
                arr[x-1] = false;
                flag--;
                return x - 1;
            }
            else if (x != 9 && arr[x + 1] == true)
            {
                arr[x + 1] = false;
                flag--;
                return x + 1;
            }
            else
            {
                return GetNumber();
            }
        }
    }
}
