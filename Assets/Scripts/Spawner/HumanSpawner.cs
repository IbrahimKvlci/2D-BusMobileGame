using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : SpawnerBase,ISpawnerOnScreenLoad
{
    [SerializeField] GameObject station;

    private void Start()
    {
        IsFinished = false;
        Pooling = HumanPooling.Instance;
        foreach (var passenger in Pooling.ActiveGameObjects)
        {
            if (!passenger.GetComponent<Passenger>().IsPassenger)
            {
                ActiveGameObjects.Add(passenger);
                passenger.transform.position = transform.position;
                passenger.GetComponent<Passenger>().IsPassenger = true;
                break;
            }  
        }
        
    }


    public override void Spawn()
    {
        if (station.GetComponent<Station>().CountOfPassenger > 0&&ActiveGameObjects.Count==0)
        {
            GameObj = HumanPooling.Instance.GetRandomGameObjectFromPool();
            if (GameObj != null)
            {
                base.Spawn();
            }
        }
        else
        {
            IsFinished = true;
        }

    }

    public void Run()
    {
       Spawn();
    }
}
