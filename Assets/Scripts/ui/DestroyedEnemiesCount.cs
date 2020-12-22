using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyedEnemiesCount : MonoBehaviour
{
    public int destroyedEnemyCount;

    public TextMeshProUGUI destroyedEnemyText;

    public TextMeshProUGUI titleText;

    public static DestroyedEnemiesCount Singleton;
    void Start()
    {
        Singleton = this;

        destroyedEnemyCount = 0;
    }
    private void Update()
    {
        destroyedEnemyText.text = "Destroyed enemies: " + destroyedEnemyCount.ToString();

        if (PlayerModel.Singleton.health < 1)
        {
            titleText.text = "YOU LOSE";
        }
    }
}
