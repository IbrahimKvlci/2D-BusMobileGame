using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] bool _start;
    [SerializeField] bool _end;

    IMovable[] _movableObjects;
    ISpawner[] _spawners;

    public bool IsGameOver { get; set; } 

    public static GameController Instance { get; private set; }

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
       
    }

    private void Start()
    {
        _start = false;
        IsGameOver = false;
        _movableObjects = FindObjectsOfType<MonoBehaviour>(true).OfType<IMovable>().ToArray();
        _spawners = FindObjectsOfType<MonoBehaviour>(true).OfType<ISpawner>().ToArray();
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
        foreach (var item in _movableObjects)
        {
            if (item.CanMove)
            {
                item.Move();

            }
            
        }
        foreach (var item in _spawners)
        {
            item.Spawn();
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over!");
        IsGameOver = true;
    }
}
