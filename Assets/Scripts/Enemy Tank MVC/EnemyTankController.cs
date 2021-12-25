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
