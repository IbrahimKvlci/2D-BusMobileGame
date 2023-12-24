using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityGameManager : MonoBehaviour
{
    BusGameControl busGameControl;
    FinishPointGameControl finishPointGameControl;
    HumanSpawnerGameControl humanSpawnerGameControl;

    private void Awake()
    {
        busGameControl= GetComponent<BusGameControl>();
        finishPointGameControl= GetComponent<FinishPointGameControl>();
        humanSpawnerGameControl=GetComponent<HumanSpawnerGameControl>();
    }

    private void Update()
    {
        if (busGameControl.CheckEntityTaskFinished()&& !GameController.Instance.IsFinished && finishPointGameControl.CheckEntityTaskFinished() && humanSpawnerGameControl.CheckEntityTaskFinished())
        {
            GameController.Instance.Finish();
        }
        else if (busGameControl.CheckEntityTaskFinished()&& !GameController.Instance.IsFinished && !GameController.Instance.IsGameOver)
        {
            GameController.Instance.GameOver();
        }
        
    }
}
