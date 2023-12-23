using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInScreen : MonoBehaviour
{
    private void Start()
    {

        print(ScreenCalculator._instance.Width);
        if (transform.position.x > 0)
        {
            if (transform.position.x + GetComponent<Collider2D>().bounds.size.x / 2 > ScreenCalculator._instance.Width)
            {
                transform.position = new Vector3(ScreenCalculator._instance.Width - GetComponent<Collider2D>().bounds.size.x/2, transform.position.y, transform.position.y);
            }  
        }
        else
        {
            if(transform.position.x - GetComponent<Collider2D>().bounds.size.x/2 < ScreenCalculator._instance.Width)
            {
                transform.position = new Vector3(-ScreenCalculator._instance.Width + GetComponent<Collider2D>().bounds.size.x/2, transform.position.y, transform.position.y);
            }
        }
    }
}
