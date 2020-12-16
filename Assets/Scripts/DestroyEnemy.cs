using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{

    public EnemyModel enemyModel;

    public TowerModel towerModel;

    private void Update()
    {
        if (enemyModel.health < 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Base")
        {
            EnemyCreator.Singleton.enemyList.Remove(gameObject);

            Destroy(gameObject);
            
        }

        if (other.tag == "Bullet")
        {
            enemyModel.health -= towerModel.damage;
        }
    }
}
