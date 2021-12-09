using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    public TankModel(float speed, int health)
    {
        Speed = speed;
        Health = health;
    }

    public float Speed { get; }
    public int Health { get; }
}
