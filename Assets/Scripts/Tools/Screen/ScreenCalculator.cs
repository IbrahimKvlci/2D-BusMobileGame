using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCalculator : MonoBehaviour
{
    public static ScreenCalculator _instance;

    float _height;
    float _width;

    public float Height
    {
        get { return _height; }
        private set { _height = value; }
    }

    public float Width
    {
        get { return _width; }
        private set { _width = value; }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }

        Height = Camera.main.orthographicSize;
        Width = Height * Camera.main.aspect;
    }
}
