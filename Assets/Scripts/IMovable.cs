using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable:IRunOnStart
{
    void Move();

    public bool CanMove { get; set; } 
}
