using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PoolingBase : MonoBehaviour,IPooling
{
    [SerializeField] List<GameObject> gameObjectPrefabs;

    [SerializeField] int amountToPool;

    [SerializeField]
    List<GameObject> gameObjects=new List<GameObject>();
    public List<GameObject> GameObjectPool
    {
        get { return gameObjects; }
        set { gameObjects = value; }
    }
    [SerializeField]
    List<GameObject> activeGameObjects = new List<GameObject>();
    public List<GameObject> ActiveGameObjects
    {
        get { return activeGameObjects; }
        set { activeGameObjects = value; }
    }

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
                GameObjectPool.Add(gameObj);
            }
        }
    }

    public GameObject GetRandomGameObjectFromPool()
    {
        if(GameObjectPool.Count > 0)
        {
            int i = Random.Range(0, GameObjectPool.Count);
            if (!GameObjectPool[i].activeInHierarchy)
            {
                return GameObjectPool[i];
            }
        }
        return null;
    }

    public GameObject GetGameObjectFromPool()
    {
        for (int i = 0;i < amountToPool; i++)
        {
            if (!GameObjectPool[i].activeInHierarchy)
            {
                return GameObjectPool[i];
            }
        }
        return null;
    }

    public bool CheckGameObjectActive()
    {
        for (int i = 0; i < GameObjectPool.Count; i++)
        {
            if (GameObjectPool[i].activeInHierarchy)
            {
                return true;
            }
        }
        return false;
    }

    public void AddActiveGameObjectToList(GameObject gameObject)
    {
        if (!ActiveGameObjects.Contains(gameObject))
        {
            ActiveGameObjects.Add(gameObject);
        }
    }
}

