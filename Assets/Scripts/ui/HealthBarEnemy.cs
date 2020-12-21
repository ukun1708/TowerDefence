using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarEnemy : MonoBehaviour
{
    public GameObject indicator;

    void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
    }

    public void HealthBarUpdate(float current)
    {
        indicator.transform.localScale = new Vector3(1f, 1f, current);
    }
}
