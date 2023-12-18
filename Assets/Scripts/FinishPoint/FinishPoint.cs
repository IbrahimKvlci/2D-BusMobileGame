using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour,IFinishPoint
{
    HumanSpawner _humanSpawner;
    ISensor _sensor;

    private void Start()
    {
        _humanSpawner=FindObjectOfType<HumanSpawner>();
    }

    private void Update()
    {
        if( _sensor != null)
        {
            if (_sensor.IsSensedOnFinishPoint())
            {
                if (_humanSpawner != null)
                {
                    if (_humanSpawner.ActiveGameObjects.Count == 0)
                    {
                        if (!GameController.Instance.IsFinished)
                        {
                            GameController.Instance.Finish();
                        }
                        
                    }
                }
                else
                {
                    if (!GameController.Instance.IsFinished)
                    {
                        GameController.Instance.Finish();
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bus"))
        {
            _sensor=collision.GetComponentInChildren<ISensor>();
        }
    }
}
