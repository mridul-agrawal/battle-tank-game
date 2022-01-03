using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankService : MonoBehaviour
{
    public EnemyTankView tankView;
    public EnemyTankScriptableObject enemyTankSO;
    public BulletScriptableObjectList bulletList;

    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        CreateEnemyTank();
    }

    private EnemyTankController CreateEnemyTank()
    {
        EnemyTankModel model = new EnemyTankModel(enemyTankSO);
        EnemyTankController tank = new EnemyTankController(model, tankView);
        tank.TankView.SetTankControllerReference(tank);
        return tank;
    }


}
