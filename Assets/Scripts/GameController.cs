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

    IPathService _pathService;

    public bool IsGameOver { get; set; }
    public bool IsFinished { get; set; }
    public bool IsPaused { get; set; }

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
        }
        
    }

    

    private void Start()
    {
        _start = false;
        IsGameOver = false;
        _runOnLoad = FindObjectsOfType<MonoBehaviour>(false).OfType<IRunOnLoad>().ToArray();
        _runOnStart = FindObjectsOfType<MonoBehaviour>(true).OfType<IRunOnStart>().ToArray();
        _pathService = GetComponent<IPathService>();
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!IsPaused)
        {
            foreach (var item in _runOnLoad)
            {
                item.Run();
            }
            if (_pathService.PathIsDone())
            {
                Play();

            }
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
        PlayerPrefsManager.SetPlayerLevel(PlayerPrefsManager.GetLevel() + 1);
        print(PlayerPrefsManager.GetCoin());
        print(CollectibleManager.Instance.CoinCount);
        PlayerPrefsManager.SetCoin(PlayerPrefsManager.GetCoin() + CollectibleManager.Instance.CoinCount);
        UIManager.instance.FinishGame();
        print("Finish");
        IsFinished = true;
        Pause();
    }

    public void PauseGame()
    {
        Pause();
    }

    public void GameOver()
    {
        UIManager.instance.GameOver();
        Debug.Log("Game Over!");
        IsGameOver = true;
        Pause();
    }

    void Pause()
    {
        IsPaused = true;
        FindObjectOfType<DrawPath>().CanDraw = false;
        Time.timeScale = 0;
    }

    public void Continue()
    {
        IsPaused = false;
        Time.timeScale = 1;
        FindObjectOfType<DrawPath>().CanDraw = true;
    }
}
