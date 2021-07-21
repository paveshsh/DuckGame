using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbDie : MonoBehaviour
{
    public GameObject numKiller;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(numKiller.transform.position, numKiller.transform.forward);
        if (hitInfo.collider != null && hitInfo.collider.TryGetComponent(out DuckMove target))
        {
            Destroy(target.gameObject);
        }
    }
}
