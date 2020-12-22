using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EnemyCreator : MonoBehaviour
{
    public GameObject enemyPrefabs;

    public GameObject winMenu;

    public Transform pointSpawn;

    public CinemachineSmoothPath path;

    static string enemyTag;

    public List<GameObject> enemyList;

    public static EnemyCreator Singleton;

    public List<EnemyWaveModel> enemyWaveModels;

    public int countEnemy;

    public int waveIndex = 0;

    void Start()
    {
        Singleton = this;

        winMenu.SetActive(false);

        StartCoroutine(CreateWave(enemyWaveModels[waveIndex]));
    }
    void Update()
    {
        if (waveIndex == 3)
        {
            winMenu.SetActive(true);
        }
    }

    IEnumerator CreateWave(EnemyWaveModel enemyModel)
    {
        enemyList = new List<GameObject>();

        int enemyCount = Random.Range(enemyModel.minEnemyCount, enemyModel.maxEnemyCount);

        for (int i = 0; i < enemyCount; i++)
        {
            GameObject enemy = Instantiate(enemyPrefabs, pointSpawn.position, Quaternion.identity);

            enemy.GetComponent<PathMover>().m_Path = path;
            enemy.GetComponent<PathMover>().speed = enemyModel.speed;
            enemy.GetComponent<EnemyModel>().health = enemyModel.health;
            enemy.GetComponent<EnemyModel>().damage = enemyModel.damage;
            enemy.GetComponent<EnemyModel>().getGold = enemyModel.getGold;
            enemyList.Add(enemy);
            enemyTag = "Enemy";
            enemy.tag = enemyTag;

            yield return new WaitForSeconds(enemyModel.timeWait);
        }

        while (enemyList.Count > 0)
        {
            yield return null;
        }

        waveIndex++;

        if (waveIndex < enemyWaveModels.Count)
        {
            StartCoroutine(CreateWave(enemyWaveModels[waveIndex]));
        }
    }
}
