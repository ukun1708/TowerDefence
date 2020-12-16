using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public int health;
    public int gold;

    private void Start()
    {
        health = 100;
        gold = 0;
    }
}

