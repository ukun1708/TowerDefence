using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToBase : MonoBehaviour
{
    public PlayerModel playerModel;

    public EnemyModel enemyModel;
    void Start()
    {
        
    }
    void Update()
    {
        if (playerModel.health < 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            playerModel.health -= enemyModel.damage;
        }
    }


}
