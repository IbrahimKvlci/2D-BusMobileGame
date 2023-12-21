using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject _pausePanel,_finishPanel,_gameOverPanel;

    public static UIManager instance;

    private void Start()
    {
        instance = this;
    }

    public void PauseGameBtn()
    {
        GameController.Instance.PauseGame();
        _pausePanel.SetActive(true);
    }

    public void FinishGame()
    {
        _finishPanel.SetActive(true);
    }

    public void GameOver()
    {
        _gameOverPanel.SetActive(true);
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //GameController.Instance.Continue();
    }

    public void Continue()
    {
        _pausePanel.SetActive(false);
        GameController.Instance.Continue();
    }
}
