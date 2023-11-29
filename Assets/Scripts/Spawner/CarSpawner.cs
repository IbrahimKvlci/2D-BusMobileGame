using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : SpawnerBase,ISpawner
{
    [SerializeField] float timeToSpawnCar;

    float timer = 0;

    public override GameObject GameObj { get => CarPooling.Instance.GetGameObjectFromPool(); }

    public override void Spawn()
    {
        timer += Time.deltaTime;
        if(timer > timeToSpawnCar)
        {
            base.Spawn();
            timer = 0;
        }
    }

}
