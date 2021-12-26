using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankChasingState : TankBaseState
{
    public override void EnterState()
    {
        base.EnterState();
        Debug.Log("Entering State: Patrolling");
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    protected override void Update()
    {
        // Chasing Logic & change State Logic.
    }

}
