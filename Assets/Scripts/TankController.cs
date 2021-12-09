using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TankController
{
    public TankController(TankModel tankModel, TankView tankPrefab)
    {
        TankModel = tankModel;
        TankView = GameObject.Instantiate<TankView>(tankPrefab);
    }

    public TankModel TankModel { get; }
    public TankView TankView { get; }

    public void HandleJoyStickInput(Joystick joystick)
    {
        float XAxisMovement = joystick.Horizontal * TankModel.Speed;
        float ZAxisMovement = joystick.Vertical * TankModel.Speed;
        // transform.position += new Vector3(XAxisMovement, 0, ZAxisMovement);
    }

}
