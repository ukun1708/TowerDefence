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
            EnemyModel model = other.gameObject.GetComponent<EnemyModel>();

            playerModel.health -= model.damage;
        }

        if (playerModel.health < 1)
        {
            EnemyCreator.Singleton.winMenu.SetActive(true);
        }
    }


}
