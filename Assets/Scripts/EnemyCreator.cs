using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EnemyCreator : MonoBehaviour
{
    public GameObject enemyPrefabs;

    public Transform pointSpawn;

    public float waitTime;

    public CinemachineSmoothPath path;

    static string enemy = "Enemy";

    public List<GameObject> enemyList = new List<GameObject>();

    public static EnemyCreator Singleton;

    int enemyCount;

    bool waveOne, waveTwo, waveThree;

    void Start()
    {
        Singleton = this;

        waveOne = true;

        waveTwo = false;

        waveThree = false;

        waitTime = 2;

        enemyCount = Random.Range(10, 20);

        
        
    }
    void Update()
    {
        if (waveOne == true)
        {
            StartCoroutine(CreateWaveOne(waitTime));

            waveOne = false;

            if (enemyCount <= 0)
            {
                waveTwo = true;

                if (waveTwo == true)
                {
                    StartCoroutine(CreateWaveTwo(waitTime));

                    waveTwo = false;
                }
            }
        }
    }

    IEnumerator CreateWaveOne(float repeatTime)
    {
        for (int i = 0; i < enemyCount; i++)
        {
            enemyPrefabs.GetComponent<PathMover>().m_Path = path;
            enemyPrefabs.GetComponent<PathMover>().speed = 10f;
            enemyList.Add(Instantiate(enemyPrefabs, pointSpawn.position, Quaternion.identity));
            enemyPrefabs.tag = enemy;

            yield return new WaitForSeconds(repeatTime);
        }
    }

    IEnumerator CreateWaveTwo(float repeatTime)
    {
        for (int i = 0; i < enemyCount; i++)
        {
            enemyPrefabs.GetComponent<PathMover>().m_Path = path;
            enemyList.Add(Instantiate(enemyPrefabs, pointSpawn.position, Quaternion.identity));
            enemyPrefabs.tag = enemy;

            yield return new WaitForSeconds(repeatTime);
        }

        yield return new WaitForSeconds(5f);
    }
}
