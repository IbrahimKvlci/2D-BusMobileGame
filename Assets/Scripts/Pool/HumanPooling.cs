using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanPooling : PoolingBase,IPooling
{
   public static HumanPooling Instance { get; private set; }

    private void Awake()
    {
        if(Instance==null)
        {
            Instance = this;
        }
    }

    public override void Start()
    {
        base.Start();
        var activeGameObject= GetRandomGameObjectFromPool();
        activeGameObject.SetActive(true);
        ActiveGameObjects.Add(activeGameObject);

    }


}
