using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnerBase : MonoBehaviour, ISpawner
{
    public virtual GameObject GameObj { get;}

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
