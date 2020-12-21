using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HealthCount : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    void Update()
    {
        healthText.text = PlayerModel.Singleton.health.ToString();
    }
}
