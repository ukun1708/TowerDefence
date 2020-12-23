using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToBase : MonoBehaviour, Idamage
{
    PlayerModel playerModel;
    void Start()
    {
        playerModel = GetComponent<PlayerModel>();
    }

    public void TakeDamage(float damage)
    {
        playerModel.health -= damage;

        if (playerModel.health < 1)
        {
            EnemyCreator.Singleton.winMenu.SetActive(true);

            foreach (GameObject enemy in EnemyCreator.Singleton.enemyList)
            {
                enemy.GetComponent<PathMover>().speed = 0f;
            }

            FollowEnemy.Singleton.shoting = false;
        }
    }
}
