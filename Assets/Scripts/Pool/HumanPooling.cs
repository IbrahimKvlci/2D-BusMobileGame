using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        int countOfStation=FindObjectsOfType<MonoBehaviour>(false).OfType<IStation>().Count();
        for (int i = 0; i < countOfStation; i++)
        {
            var activeGameObject = GetRandomGameObjectFromPool();
            ActiveGameObjects.Add(activeGameObject);
            activeGameObject.SetActive(true);
        }
    }


}
