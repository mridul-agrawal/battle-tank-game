using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankController 
{
    public EnemyTankController(EnemyTankModel tankModel, EnemyTankView tankPrefab)
    {
        TankModel = tankModel;
        TankView = GameObject.Instantiate<EnemyTankView>(tankPrefab);
    }

    public EnemyTankModel TankModel { get; }
    public EnemyTankView TankView { get; }
}
