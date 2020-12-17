using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Wave", menuName = "ScriptableObjects/WaveModel", order = 1)]
public class EnemyWaveModel : ScriptableObject
{
    public int health;
    public int damage;
    public int getGold;
    public float speed;
    public int minEnemyCount;
    public int maxEnemyCount;
    public float timeWait;
}