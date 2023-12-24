using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour, IFinishPoint
{
    HumanSpawner _humanSpawner;
    ISensor _sensor;

    public bool IsFinished { get;set; }

    private void Start()
    {
        IsFinished = false;
        _humanSpawner =FindObjectOfType<HumanSpawner>();
    }

    private void Update()
    {
        if( _sensor != null)
        {
            if (_sensor.IsSensedOnFinishPoint())
            {
                IsFinished = true;
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
