using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerModel : MonoBehaviour
{
    public int damage;
    public float speedShot;

    private void Start()
    {
        damage = 10;
        speedShot = 5f;
    }
}