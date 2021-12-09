using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{
    public TankView tankView;
    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        for(int i=0; i<5; i++)
        {
            CreateNewTank();
        }
    }

    private TankController CreateNewTank()
    {
        TankModel tankModel = new TankModel(2f, 100);
        TankController tankController = new TankController(tankModel, tankView);
        return tankController;
    }

}
