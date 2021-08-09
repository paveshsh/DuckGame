using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public Camera _cam;
    public int score = 0;
    public int score2 = 0;
    public Text scoreText;
    public AudioClip shootSound;
    public AudioClip duckByeSound;
    public AudioSource _audioSource;
    public Text purpose;
    public GameObject spawner;
    public GameObject GoodEf;
    public GameObject BadEf;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        scoreText.text = score.ToString();
    }

    void Shoot()
    {
        score2++;
        _audioSource.PlayOneShot(shootSound);
        RaycastHit2D hitInfo = Physics2D.Raycast(_cam.transform.position, _cam.transform.forward);
        if (hitInfo.collider != null && hitInfo.collider.TryGetComponent(out TargetLive target))
        {
            if (target.isActive == true)
            {
                _audioSource.PlayOneShot(duckByeSound);
                target.ByeDuck();
                if (target.duckNumb == purpose.GetComponent<NewRandomPurpose>().intNewPurpose)
                {
                    score += 1;
                    GameObject newGoodEffect = Instantiate(GoodEf, new Vector3(0, 0, 0), Quaternion.identity);
                    Destroy(newGoodEffect, 2);
                    purpose.GetComponent<NewRandomPurpose>().flag = false;
                    spawner.GetComponent<DuckSpawner>().flag = 0;
                }
            }
        }
        else
        {
            GameObject newBadEffect = Instantiate(BadEf, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(newBadEffect, 2);
        }
    }
}
