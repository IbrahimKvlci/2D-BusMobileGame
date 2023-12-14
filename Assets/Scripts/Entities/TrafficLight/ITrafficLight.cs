using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITrafficLight:IRunOnStart
{
    void AdjustTrafficLight();

    public bool Light { get; set; }
}
