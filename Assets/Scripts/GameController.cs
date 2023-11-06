using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] bool _start;

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
            foreach (var item in _busControllers)
            {
                if (item._canDrive)
                {
                    item.Drive();
                }
            }

        }
    }
}
