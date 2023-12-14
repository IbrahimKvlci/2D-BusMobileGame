using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class BusController : MonoBehaviour, IMovable
{
    [SerializeField] Transform _path;

    [SerializeField] float _rotationSpeed,_speed,_distance;

    [SerializeField] int _counterFirstValue;

    int _counter;

    public bool CanMove { get ; set ; }

    private void Start()
    {
        _counter = _counterFirstValue;
        CanMove = true;
    }

    public void Move()
    {
        Vector3 far = _path.GetChild(_counter + 1).position - _path.GetChild(_counter).position;
        if(_counter == _counterFirstValue)
        {
            far = _path.GetChild(_counter + 1).position - transform.position;
        }
        far.Normalize();
        transform.position += far * Time.deltaTime * _speed;
        Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, far);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, _rotationSpeed * Time.deltaTime);


        if (Vector3.Distance(transform.position, _path.GetChild(_counter + 1).position) < _distance)
        {
            _counter++;
        }
        if (_counter == _path.childCount - 1)
        {
            CanMove = false;
        }
    }

    public void Run()
    {
        if(CanMove)
        {
            Move();
        }
        
    }
}
