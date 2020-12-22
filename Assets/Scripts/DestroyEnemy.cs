using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{    
    EnemyModel enemyModel;

    public TowerModel towerModel;

    public HealthBarEnemy healthBar;

    private void Start()
    {
        enemyModel = GetComponent<EnemyModel>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Base")
        {
            EnemyCreator.Singleton.enemyList.Remove(gameObject);
            Destroy(gameObject, 0.2f);
        }

        if (other.tag == "Bullet")
        {
            healthBar.HealthBarUpdate(enemyModel.health / enemyModel.maxHealth);

            if (enemyModel.health < 1)
            {
                DestroyedEnemiesCount.Singleton.destroyedEnemyCount += 1;

                PlayerModel.Singleton.gold += enemyModel.getGold;

                EnemyCreator.Singleton.enemyList.Remove(gameObject);
                Destroy(gameObject);
            }
        }
    }
}
