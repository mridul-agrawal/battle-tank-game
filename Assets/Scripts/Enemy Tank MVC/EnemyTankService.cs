using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankService : MonoBehaviour
{
    public EnemyTankView tankView;
    public TankScriptableObjectList enemyTankList;
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
        EnemyTankModel model = new EnemyTankModel(enemyTankList.TankSOList[0]);
        EnemyTankController tank = new EnemyTankController(model, tankView);
        tank.TankView.SetTankControllerReference(tank);
        return tank;
    }


}
