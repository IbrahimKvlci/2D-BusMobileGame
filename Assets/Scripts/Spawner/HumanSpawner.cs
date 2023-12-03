using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : SpawnerBase, ISpawner
{

    private void Start()
    {
        Pooling = HumanPooling.Instance;
    }


    public override void Spawn()
    {
        if(HumanPooling.Instance.GameObjectPool.Count> 0)
        {
            if (!HumanPooling.Instance.CheckGameObjectActive())
            {

                GameObj = HumanPooling.Instance.GetRandomGameObjectFromPool();
                if (GameObj != null)
                {
                    base.Spawn();

                }

            }
        }
        
        

        
    }
}
