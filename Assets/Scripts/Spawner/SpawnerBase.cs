using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnerBase : MonoBehaviour, ISpawner
{
    

    [SerializeField] float timeToSpawn;

    float timer = 0;

    IPooling _pooling;
    public virtual IPooling Pooling
    {
        get
        {
            return _pooling;
        }
        set { _pooling = value; }
    }

    GameObject _gameObj;
    public virtual GameObject GameObj
    {
        get
        {
            return _gameObj;
        }
        set { _gameObj = value; }
    }

    List<GameObject> _activeGameObjects=new List<GameObject>();
    public List<GameObject> ActiveGameObjects
    {
        get { return _activeGameObjects; }
        set { _activeGameObjects = value; }
    }

    public virtual void Spawn()
    {
        if(!ActiveGameObjects.Contains(GameObj))
        {
            timer += Time.deltaTime;
            if (timer > timeToSpawn)
            {
                GameObj.SetActive(true);
                ActiveGameObjects.Add(GameObj);
                GameObj.transform.position = transform.position;
                GameObj.transform.rotation = transform.rotation;
                timer = 0;
            }
        } 
    }
}
