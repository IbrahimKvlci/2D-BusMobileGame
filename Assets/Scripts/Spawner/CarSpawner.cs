using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : SpawnerBase,ISpawner
{

    public override void Spawn()
    {
        GameObj = CarPooling.Instance.GetRandomGameObjectFromPool();
        if (GameObj != null)
        {
            base.Spawn();
            CarPooling.Instance.activeGameObjects.Add(GameObj);
        }
    }

}
