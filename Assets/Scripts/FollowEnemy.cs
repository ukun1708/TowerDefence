using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public float speedRotation = 5f;

    Vector3 direction;

    public TowerModel towerModel;

    public EnemyWaveModel enemyModel;

    public float findRadius = 30f;

    GameObject targetEnemy = null;

    public GameObject bullet;

    string bulletTag = "Bullet";

    bool isShot;

    private void Start()
    {
        isShot = false;
    }

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

            if (isShot == false)
            {
                StartCoroutine(Shot());
            }

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

    IEnumerator Shot()
    {
        isShot = true;
        yield return new WaitForSeconds(towerModel.speedShot);        

        Instantiate(bullet, transform.position, transform.rotation);
        bullet.tag = bulletTag;
        isShot = false;

        if (targetEnemy != null)
        {
            targetEnemy.GetComponent<EnemyModel>().health -= towerModel.damage;
        }
    }
}
