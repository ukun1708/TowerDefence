using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EnemyCreator : MonoBehaviour
{
    public GameObject enemyPrefabs;

    public Transform pointSpawn;

    //public Transform[] movementPoins;

    public float timeCreate;

    public float timeRepeat;

    public CinemachineSmoothPath path;

    void Start()
    {
        InvokeRepeating("Create", timeCreate, timeRepeat);
    }
    void Update()
    {
        
    }

    void Create()
    {
        enemyPrefabs.GetComponent<PathMover>().m_Path = path;
        Instantiate(enemyPrefabs, pointSpawn.position, Quaternion.identity);        
    }
}
