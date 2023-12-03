using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPooling
{
    GameObject GetGameObjectFromPool();
    GameObject GetRandomGameObjectFromPool();

    void AddActiveGameObjectToList(GameObject gameObject);

    bool CheckGameObjectActive();

    public List<GameObject> GameObjectPool { get; set; }
    public List<GameObject> ActiveGameObjects { get; set; }
}
