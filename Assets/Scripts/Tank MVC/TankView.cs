using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This Class is Attached to a Player Tank GameObject and is responsible for rendering and UI related work.
/// </summary>
public class TankView : MonoBehaviour
{
    public GameObject Turret;
    public Transform BulletSpawner;
    private TankController tankController;

    private void FixedUpdate()
    {
        tankController.HandleLeftJoyStickInput(GetComponent<Rigidbody>());
        tankController.HandleRightJoyStickInput(Turret.transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            tankController.DestroyWorld();
        }
    }

    // Sets a reference to the corresponding TankController Script.
    public void SetTankControllerReference(TankController controller)
    {
        tankController = controller;
    }

}



