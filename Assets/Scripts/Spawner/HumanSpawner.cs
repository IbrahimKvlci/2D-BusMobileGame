using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : SpawnerBase, ISpawner
{
    [SerializeField] GameObject station;

    private void Start()
    {
        Pooling = HumanPooling.Instance;
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

    }
}
