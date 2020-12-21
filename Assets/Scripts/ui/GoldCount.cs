using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldCount : MonoBehaviour
{
    public TextMeshProUGUI goldText;
    void Update()
    {
        goldText.text = PlayerModel.Singleton.gold.ToString();
    }
}
