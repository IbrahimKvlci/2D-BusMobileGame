using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable
{
    void Move();

    public bool CanMove { get; set; } 
}
