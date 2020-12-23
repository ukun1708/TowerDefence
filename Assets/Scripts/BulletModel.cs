using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel : MonoBehaviour
{
    public float speedBullet = 10f;

    float damage;

    public TowerModel towerModel;

    public EnemyWaveModel enemyModel;

    void Start()
    {
        damage = towerModel.damage;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speedBullet * Time.deltaTime, Space.Self);

        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Idamage idam = null;

        other.TryGetComponent<Idamage>(out idam);

        if (idam != null)
        {
            idam.TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}
