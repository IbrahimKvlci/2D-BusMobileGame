using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStation
{
    public HumanSpawner HumanSpawner { get; set; }
    public int CountOfPassenger { get; set; }
}
