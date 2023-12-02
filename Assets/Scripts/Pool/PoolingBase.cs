using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PoolingBase : MonoBehaviour,IPooling
{
    [SerializeField] List<GameObject> gameObjectPrefabs;

    [SerializeField] int amountToPool;

    public List<GameObject> gameObjectPool=new List<GameObject>();
    public List<GameObject> activeGameObjects=new List<GameObject>();


    private void Start()
    {
        foreach (var prefab in gameObjectPrefabs)
        {
            for (int i = 0; i < amountToPool; i++)
            {
                var gameObj=Instantiate(prefab);
                gameObj.name = i.ToString();
                gameObj.SetActive(false);
                gameObj.transform.SetParent(transform);
                gameObjectPool.Add(gameObj);
            }
        }
    }

    public GameObject GetRandomGameObjectFromPool()
    {
        if(gameObjectPool.Count > 0)
        {
            int i = Random.Range(0, gameObjectPool.Count);
            if (!gameObjectPool[i].activeInHierarchy)
            {
                return gameObjectPool[i];
            }
        }
        return null;
    }

    public GameObject GetGameObjectFromPool()
    {
        for (int i = 0;i < amountToPool; i++)
        {
            if (!gameObjectPool[i].activeInHierarchy)
            {
                return gameObjectPool[i];
            }
        }
        return null;
    }

    public bool CheckGameObjectActive()
    {
        for (int i = 0; i < gameObjectPool.Count; i++)
        {
            if (gameObjectPool[i].activeInHierarchy)
            {
                return true;
            }
        }
        return false;
    }

   
}

