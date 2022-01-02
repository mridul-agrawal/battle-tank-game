using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventHandler : SingletonGeneric<EventHandler>
{
    public event Action OnBulletFired;

    public void InvokeOnBulletFired()
    {
        OnBulletFired?.Invoke();
    }

}
