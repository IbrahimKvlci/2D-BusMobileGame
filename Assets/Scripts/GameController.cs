using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] bool _start;
    [SerializeField] bool _end;

    BusController[] _busControllers;

    private void Start()
    {
        _start = false;
        _busControllers=FindObjectsOfType<BusController>();
    }

    void Update()
    {
        if (_start)
        {
            Play();

        }
    }

    public void Play()
    {
        foreach (var item in _busControllers)
        {
            if (item._canDrive)
            {
                item.Drive();
            }
        }
    }

    public void GameOver()
    {

    }
}
