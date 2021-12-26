using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankView : MonoBehaviour, IDamagable
{
    private EnemyTankController enemyTankController;
    private TankBaseState currentState;
    [SerializeField]
    private TankBaseState startingState;
    [SerializeField]
    public TankPatrollingState patrollingState;
    [SerializeField]
    public TankChasingState chasingState;

    private void Start()
    {
        ChangeState(startingState);
    }

    public void SetTankControllerReference(EnemyTankController controller)
    {
        enemyTankController = controller;
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("Enemy Tank Taking Damage: " + damage, gameObject);
        enemyTankController.ApplyDamage(damage);
    }

    public void ChangeState(TankBaseState newTankState)
    {
        if(currentState != null)
        {
            currentState.ExitState();
        }
        currentState = newTankState;
        currentState.EnterState();
    }

}
