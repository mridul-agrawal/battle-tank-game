using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController 
{
    // This Constructor Spawns a bullet and Fire it just after it is Spawned.
    public BulletController(BulletModel bulletModel, BulletView bulletView, Transform BulletSpawner)
    {
        BulletModel = bulletModel;
        BulletView = GameObject.Instantiate<BulletView>(bulletView, BulletSpawner.position, BulletSpawner.rotation);
        BulletView.GetComponent<Rigidbody>().AddForce(BulletView.transform.forward * BulletModel.Speed, ForceMode.VelocityChange);
    }

    public BulletModel BulletModel { get; }
    public BulletView BulletView { get; }

}
