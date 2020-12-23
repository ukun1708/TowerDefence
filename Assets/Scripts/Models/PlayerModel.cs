using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public float health;
    public int gold;

    public static PlayerModel Singleton;

    private void Start()
    {
        Singleton = this;

        health = 100f;
        gold = 0;
    }
}

