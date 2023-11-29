using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour, IMovable
{
    [SerializeField] float _speed;

    public bool CanMove { get; set; }

    private void Start()
    {
        CanMove = true;
        
    }


    public void Move()
    {
        transform.Translate(Vector3.up * _speed*Time.deltaTime);
    }
}
