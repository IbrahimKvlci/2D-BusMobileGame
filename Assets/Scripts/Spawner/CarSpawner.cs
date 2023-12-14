using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : SpawnerBase, ISpawnerOnPlay
{
    [SerializeField] GameObject _trafficLight;

    private void Start()
    {
        Pooling=CarPooling.Instance;
    }

    public override void Spawn()
    {
        GameObj = CarPooling.Instance.GetRandomGameObjectFromPool();
        if (GameObj != null)
        {
            base.Spawn();
        }
    }

    public void Run()
    {
        if (_trafficLight.GetComponent<ITrafficLight>().Light)
        Spawn();
    }
}
