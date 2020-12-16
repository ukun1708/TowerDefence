using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel : MonoBehaviour
{
    public int health;
    public int damage;
    public int getGold;

    private void Start()
    {
        health = 100;
        damage = 10;
        getGold = 1;
    }
}