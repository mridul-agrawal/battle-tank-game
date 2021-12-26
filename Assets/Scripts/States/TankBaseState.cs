using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyTankView))]
public class TankBaseState : MonoBehaviour
{
    EnemyTankView tankView;

    private void Awake()
    {
        tankView = GetComponent<EnemyTankView>();
    }

    public virtual void EnterState()
    {
        this.enabled = true;
    }

    public virtual void ExitState()
    {
        this.enabled = false;
    }

    protected virtual void Update()
    {
        
    }
}
