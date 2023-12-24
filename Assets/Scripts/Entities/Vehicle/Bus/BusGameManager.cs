using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusGameManager : MonoBehaviour
{
    BusController[] busControllers;

    private void Awake()
    {
        busControllers=FindObjectsOfType<BusController>();
    }

    private void Update()
    {
        if (CheckBusMoveFinished()&&!GameController.Instance.IsFinished&&!GameController.Instance.IsGameOver)
        {
            GameController.Instance.GameOver();
        }
    }

    bool CheckBusMoveFinished()
    {
        foreach (var busController in busControllers)
        {
            //if (!busController.BusMoveFinished)
            //{
            //    return false;
            //}
        }
        return true;
    }
}
