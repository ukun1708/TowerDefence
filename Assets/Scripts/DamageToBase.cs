using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToBase : MonoBehaviour
{
    PlayerModel playerModel;
    void Start()
    {
        playerModel = GetComponent<PlayerModel>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            playerModel.health -= other.GetComponent<EnemyModel>().damage;
        }

        if (playerModel.health < 1)
        {
            Destroy(gameObject);
        }
    }


}
