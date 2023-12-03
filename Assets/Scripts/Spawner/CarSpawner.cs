using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : SpawnerBase,ISpawner
{

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

}
