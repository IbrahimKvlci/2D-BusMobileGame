using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class EntityGameControlBase<T> : MonoBehaviour, IEntityGameControl<T> where T : class, IFinishable
{
    public List<T> FinishableEntites { get; set; }

    private void Awake()
    {
        FinishableEntites=FindObjectsOfType<MonoBehaviour>().OfType<T>().ToList();
    }

    public bool CheckEntityTaskFinished()
    {
        foreach (var item in FinishableEntites)
        {
            if (!item.IsFinished)
            {
                return false;
            }
        }
        return true;
    }
}
