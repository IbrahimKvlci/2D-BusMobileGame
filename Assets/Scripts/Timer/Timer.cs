using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float TotalTime { get; set; } = 0;
    public float PassedTime { get; set; } = 0;

    public bool IsRunning { get; set; }
    public bool IsStarted { get; set; }
    public bool IsFinished { get; set; }

    public void Run()
    {
        if (TotalTime > 0)
        {
            IsRunning = true;
            IsStarted = true;
            IsFinished = false;
            PassedTime = 0;
        }
    }



    void Update()
    {
        if (IsRunning)
        {
            PassedTime += Time.deltaTime;
            if (PassedTime >= TotalTime)
            {
                IsFinished = true;
                IsRunning = false;
            }
        }
    }
}
