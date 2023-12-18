using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : SpawnerBase,ISpawnerOnScreenLoad
{
    [SerializeField] GameObject station;

    private void Start()
    {
        Pooling = HumanPooling.Instance;
        ActiveGameObjects.Add(Pooling.ActiveGameObjects[0]);
        Pooling.ActiveGameObjects[0].transform.position = transform.position;
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

    public void Run()
    {
       Spawn();
    }
}
