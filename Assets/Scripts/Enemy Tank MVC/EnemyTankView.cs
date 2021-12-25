using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankView : MonoBehaviour, IDamagable
{
    private EnemyTankController enemyTankController;

    public void SetTankControllerReference(EnemyTankController controller)
    {
        enemyTankController = controller;
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("Enemy Tank Taking Damage: " + damage, gameObject);
        enemyTankController.ApplyDamage(damage);
    }
}
