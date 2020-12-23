using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour, Idamage
{    
    EnemyModel enemyModel;

    public TowerModel towerModel;

    public HealthBarEnemy healthBar;

    private void Start()
    {
        enemyModel = GetComponent<EnemyModel>();
    }

    private void Update()
    {
        if (enemyModel.health < 1)
        {
            PlayerModel.Singleton.gold += enemyModel.getGold;

            EnemyCreator.Singleton.enemyList.Remove(gameObject);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Base")
        {
            EnemyCreator.Singleton.enemyList.Remove(gameObject);
            Destroy(gameObject, 0.2f);
        }
    }

    public void TakeDamage(float damage)
    {
        enemyModel.health -= damage;

        healthBar.HealthBarUpdate(enemyModel.health / enemyModel.maxHealth);
    }
}
