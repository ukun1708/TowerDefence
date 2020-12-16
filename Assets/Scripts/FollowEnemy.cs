using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public float speedRotation = 5f;

    Vector3 direction;

    public GameObject bullet;

    public TowerModel towerModel;

    public GameObject muzzleOfTheTower;

    float timer = 0f;

    public float findRadius = 30f;

    GameObject targetEnemy = null;

    void Update()
    {
        if (targetEnemy == null)
        {
            FindEnemy();
        }
        else
        {
            direction = targetEnemy.transform.position - transform.position;

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * speedRotation);

            float dist = Vector3.Distance(targetEnemy.transform.position, transform.position);

            shot();

            if (dist > findRadius)
            {
                targetEnemy = null;
            }
        }
    }

    void FindEnemy()
    {
        float min = findRadius;

        GameObject minEnemy = null;

        foreach (GameObject enemy in EnemyCreator.Singleton.enemyList)
        {
            float dist = Vector3.Distance(transform.position, enemy.transform.position);

            if (dist <= min)
            {
                min = dist;

                minEnemy = enemy;
            }
        }

        targetEnemy = minEnemy;
    }

    void shot()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            timer = towerModel.speedShot;
            // выстрел       

        }
    }
}
