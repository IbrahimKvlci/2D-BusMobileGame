using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIManager : MonoBehaviour
{
    [SerializeField] TMP_Text _coinText;

    private void Start()
    {
        SetCoinCount();
    }

    public void Play()
    {
        SceneManager.LoadScene(PlayerPrefsManager.GetLevel());
    }

    public void Levels()
    {
        SceneManager.LoadScene(1);
    }

    void SetCoinCount()
    {
        _coinText.text = PlayerPrefsManager.GetCoin().ToString();
    }
}
