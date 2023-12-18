using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] bool _start;
    [SerializeField] bool _end;

    IRunOnLoad[] _runOnLoad;
    IRunOnStart[] _runOnStart;

    public bool IsGameOver { get; set; }
    public bool IsFinished { get; set; }

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
        _runOnLoad = FindObjectsOfType<MonoBehaviour>(true).OfType<IRunOnLoad>().ToArray();
        _runOnStart = FindObjectsOfType<MonoBehaviour>(true).OfType<IRunOnStart>().ToArray();
        
    }

    void Update()
    {
        foreach (var item in _runOnLoad)
        {
            item.Run();
        }
        if (_start)
        {
            Play();

        }
    }

    public void Play()
    {
        foreach (var item in _runOnStart)
        {
            item.Run();
        }
    }

    public void Finish()
    {
        print("Finish");
        IsFinished = true;
    }

    public void GameOver()
    {
        Debug.Log("Game Over!");
        IsGameOver = true;
    }
}
