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
}
