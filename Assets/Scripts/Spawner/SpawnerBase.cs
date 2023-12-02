using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnerBase : MonoBehaviour, ISpawner
{
    [SerializeField] float timeToSpawn;

    float timer = 0;

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
        timer += Time.deltaTime;
        if (timer > timeToSpawn)
        {

            if (GameObj != null)
            {
                GameObj.SetActive(true);
                GameObj.transform.position = transform.position;
                GameObj.transform.rotation = transform.rotation;
            }
            timer = 0;
        }
        
    }
}
