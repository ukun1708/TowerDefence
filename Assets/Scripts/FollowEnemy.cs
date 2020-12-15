using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{

    public float speedRotation = 5f;

    Vector3 direction;

    void Update()
    {
        var target = GameObject.FindWithTag("Enemy");

        var dist = Vector3.Distance(transform.position, target.transform.position);

        if (dist < 50f)
        {
            direction = transform.position - target.transform.position;

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * speedRotation);
        }
        
    }
}
