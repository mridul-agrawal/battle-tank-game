using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankView : MonoBehaviour
{
    private EnemyTankController enemyTankController;

    public void SetTankControllerReference(EnemyTankController controller)
    {
        enemyTankController = controller;
    }
}
