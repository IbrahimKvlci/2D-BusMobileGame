using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPooling
{
    GameObject GetGameObjectFromPool();
    GameObject GetRandomGameObjectFromPool();

    bool CheckGameObjectActive();
}
