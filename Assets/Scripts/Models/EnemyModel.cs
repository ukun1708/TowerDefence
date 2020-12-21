using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel : MonoBehaviour
{
    public float health;
    public int damage;
    public int getGold;

    public float maxHealth;

    private void Start()
    {
        maxHealth = health;
    }
}
