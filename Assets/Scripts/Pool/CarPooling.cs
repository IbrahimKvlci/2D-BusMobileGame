using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPooling : PoolingBase, IPooling 
{
    public static CarPooling Instance { get; private set; }

    public override void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        base.Awake();
    }

}
