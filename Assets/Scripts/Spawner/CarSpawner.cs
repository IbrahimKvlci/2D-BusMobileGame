using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : SpawnerBase,ISpawner
{
    [SerializeField] float timeToSpawnCar;

    float timer = 0;

    public override void Spawn()
    {
        GameObj = CarPooling.Instance.GetRandomGameObjectFromPool();
        if (GameObj != null)
        {
            timer += Time.deltaTime;
            if (timer > timeToSpawnCar)
            {

                base.Spawn();
                timer = 0;
            }
        }
    }

}
