using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPooling : PoolingBase, IPooling 
{
    public static CarPooling Instance { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

}
