using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight :MonoBehaviour, ITrafficLight
{
    [SerializeField]
    Sprite[] _lightSprites;

    [SerializeField]
    bool _light;

    [SerializeField]
    float timeToCarsMove;

    SpriteRenderer _sR;

    float timer;

    public bool Light
    {
        get { return _light; }
        set { _light = value; }
    }

    private void Start()
    {
        _sR = GetComponent<SpriteRenderer>();
        if (Light)
        {
            _sR.sprite = _lightSprites[1];
        }
        else
        {
            _sR.sprite = _lightSprites[0];
        }
        
    }

    public void AdjustTrafficLight()
    {
        timer += Time.deltaTime;
        if (timer > timeToCarsMove)
        {
            if (Light)
            {
                Light = false;
                _sR.sprite = _lightSprites[0];
            }
            else
            {
                Light = true;
                _sR.sprite = _lightSprites[1];
            }
            
            timer = 0;
        }
    }

    public void Run()
    {
        AdjustTrafficLight();
    }
}
