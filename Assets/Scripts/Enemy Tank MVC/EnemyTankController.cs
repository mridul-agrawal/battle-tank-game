using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankController 
{
    public EnemyTankModel TankModel { get; }
    public EnemyTankView TankView { get; }
    public EnemyTankController(EnemyTankModel tankModel, EnemyTankView tankPrefab)
    {
        TankModel = tankModel;
        TankView = GameObject.Instantiate<EnemyTankView>(tankPrefab);
    }

    public void RangeCheck()
    {
        TankModel.InChaseRange = Physics.CheckSphere(TankView.transform.position, TankModel.ChaseRange, TankView.playerLayerMask);
        TankModel.InAttackRange = Physics.CheckSphere(TankView.transform.position, TankModel.AttackRange, TankView.playerLayerMask);
    }

    public void ApplyDamage(int damage)
    {
        if(TankModel.Health - damage <= 0)
        {
            // death.
        } else
        {
            TankModel.Health -= damage;
        }
    }

}
