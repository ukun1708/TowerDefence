using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    
    EnemyModel enemyModel;

    public TowerModel towerModel;

    private void Start()
    {
        enemyModel = GetComponent<EnemyModel>();
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

            if (enemyModel.health < 1)
            {
                EnemyCreator.Singleton.enemyList.Remove(gameObject);
                Destroy(gameObject);
            }
        }
    }
}
