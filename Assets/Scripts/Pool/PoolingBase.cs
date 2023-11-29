using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PoolingBase : MonoBehaviour,IPooling
{
    [SerializeField] List<GameObject> gameObjectPrefabs;

    [SerializeField] int amountToPool;

    List<GameObject> gameObjectPool=new List<GameObject>();


    private void Start()
    {
        foreach (var prefab in gameObjectPrefabs)
        {
            for (int i = 0; i < amountToPool; i++)
            {
                var gameObj=Instantiate(prefab);
                gameObj.SetActive(false);
                gameObjectPool.Add(gameObj);
            }
        }
    }

    public GameObject GetGameObjectFromPool()
    {
        for(int i = 0;i < gameObjectPool.Count; i++)
        {
            if (!gameObjectPool[i].activeInHierarchy)
            {
                return gameObjectPool[i];
            }
        }
        return null;
    }
}

