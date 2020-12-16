using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrajectory : MonoBehaviour
{
    public float speedBullet = 10f;

    public TowerModel towerModel;

    public EnemyModel enemyModel;



    //private void Update()
    //{
    //    transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speedBullet);
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Enemy")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
