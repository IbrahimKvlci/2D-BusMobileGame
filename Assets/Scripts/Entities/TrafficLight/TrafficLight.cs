using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight :MonoBehaviour, ITrafficLight
{
    [SerializeField]
    bool _light;

    [SerializeField]
    float timeToCarsMove;

    float timer;

    public bool Light
    {
        get { return _light; }
        set { _light = value; }
    }

    private void Start()
    {
        if (Light)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
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
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }
            else
            {
                Light = true;
                gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            }
            
            timer = 0;
        }
    }

    public void Run()
    {
        AdjustTrafficLight();
    }
}
