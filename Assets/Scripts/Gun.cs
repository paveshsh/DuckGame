using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public Camera _cam;
    private int score = 0;
    public Text scoreText;
    public AudioClip shootSound;
    public AudioClip duckByeSound;
    public AudioSource _audioSource;
    public Text purpose;
    public GameObject spawner;

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
                    purpose.GetComponent<NewRandomPurpose>().flag = false;
                    spawner.GetComponent<DuckSpawner>().flag = 10;
                    for (int i = 0; i < 10; i++)
                    {
                        spawner.GetComponent<DuckSpawner>().arr[i] = true;
                    }
                }
            }
        }
    }
}
