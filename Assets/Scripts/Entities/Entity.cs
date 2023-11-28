using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour, IHittable
{
    public virtual void Hit()
    {
        GameController.Instance.GameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Bus>()!=null)
        {
            if(!GameController.Instance.IsGameOver) Hit();
        }
    }
}
