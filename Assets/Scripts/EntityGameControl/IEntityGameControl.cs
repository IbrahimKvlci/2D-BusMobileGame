using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntityGameControl<T> where T : class ,IFinishable
{
    bool CheckEntityTaskFinished();

    public List<T> FinishableEntites { get; set; }
}
