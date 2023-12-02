using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPooling
{
    GameObject GetGameObjectFromPool();
    GameObject GetRandomGameObjectFromPool();

    bool CheckGameObjectActive();

    public List<GameObject> GameObjectPool { get; set; }
    public List<GameObject> ActiveGameObjects { get; set; }
}
