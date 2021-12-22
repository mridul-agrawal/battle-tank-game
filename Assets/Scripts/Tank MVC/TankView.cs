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
    private float CameraZoomOutSpeed = 0.0001f;

    private void FixedUpdate()
    {
        tankController.HandleLeftJoyStickInput(GetComponent<Rigidbody>());
        tankController.HandleRightJoyStickInput(Turret.transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            DestroyWorld();
        }
    }

    private void DestroyWorld()
    {
        ZoomOutCamera(tankController.camera);
        DestroyTanks();
        DestoryEnv();
    }

    // A function to Zoom Out Camera Asynchronously when the player dies.
    private async void ZoomOutCamera(Camera camera)
    {
        float lerp = 0.01f;
        camera.transform.SetParent(null);
        while (camera.orthographicSize < 50)
        {
            camera.orthographicSize = Mathf.Lerp(tankController.camera.orthographicSize, 50, lerp);
            lerp = lerp + CameraZoomOutSpeed;
            await new WaitForSeconds(0.01f);
        }
    }

    // Destroys all Game Objects Tagged as 'Tank' one by one using async await.
    private async void DestroyTanks()
    {
        GameObject[] tanks = GameObject.FindGameObjectsWithTag("Tank");
        for (int i = 0; i < tanks.Length; i++)
        {
            GameObject.Destroy(tanks[i]);
            await new WaitForSeconds(0.1f);
        }
    }

    // Destroys all Game Objects Tagged as 'Ground' one by one using async await.
    private async void DestoryEnv()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Ground");
        for (int i = 0; i < objects.Length; i++)
        {
            GameObject.Destroy(objects[i]);
            await new WaitForSeconds(0.03f);
        }
    }

    // Sets a reference to the corresponding TankController Script.
    public void SetTankControllerReference(TankController controller)
    {
        tankController = controller;
    }

}



