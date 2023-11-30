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
                gameObj.name = i.ToString();
                gameObj.SetActive(false);
                gameObjectPool.Add(gameObj);
            }
        }
    }

    public GameObject GetGameObjectFromPool()
    {
        int i=Random.Range(0, gameObjectPool.Count); 
            if (!gameObjectPool[i].activeInHierarchy)
            {
                return gameObjectPool[i];
            }

        return null;
    }
}

