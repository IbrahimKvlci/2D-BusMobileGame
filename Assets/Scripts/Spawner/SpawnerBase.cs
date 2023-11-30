using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnerBase : MonoBehaviour, ISpawner
{
    GameObject _gameObj;
    public virtual GameObject GameObj
    {
        get
        {
            return _gameObj;
        }
        set { _gameObj = value; }
    }


    public virtual void Spawn()
    {
        if (GameObj != null)
        {
            GameObj.SetActive(true);
            GameObj.transform.position = transform.position;
            GameObj.transform.rotation = transform.rotation;
        }
    }
}
