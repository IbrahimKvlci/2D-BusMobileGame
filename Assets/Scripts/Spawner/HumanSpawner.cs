using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : SpawnerBase, ISpawner
{

    public override void Spawn()
    {
        
        if (!HumanPooling.Instance.CheckGameObjectActive())
        {
            GameObj = HumanPooling.Instance.GetRandomGameObjectFromPool();
            if (GameObj != null)
            {
                base.Spawn();
                HumanPooling.Instance.activeGameObjects.Add(GameObj);
            }
        }
        

        
    }
}
