using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawner
{
    void Spawn();
    public List<GameObject> ActiveGameObjects { get; set; }
}
