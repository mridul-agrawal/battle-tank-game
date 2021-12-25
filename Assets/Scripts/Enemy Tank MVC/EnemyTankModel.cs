using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankModel 
{
    public EnemyTankModel(TankScriptableObject tankScriptableObject)
    {
        Speed = tankScriptableObject.speed;
        Health = tankScriptableObject.health;
        RotationSpeed = tankScriptableObject.rotationSpeed;
        TankName = tankScriptableObject.TankName;
    }

    public float Speed { get; }
    public int Health { get; set; }
    public float RotationSpeed { get; }
    public string TankName { get; }
}
