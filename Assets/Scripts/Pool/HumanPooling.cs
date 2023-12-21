using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanPooling : PoolingBase,IPooling
{
   public static HumanPooling Instance { get; private set; }


    public override void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        base.Awake();
        var activeGameObject= GetRandomGameObjectFromPool();
        ActiveGameObjects.Add(activeGameObject);
        activeGameObject.SetActive(true);
    }


}
