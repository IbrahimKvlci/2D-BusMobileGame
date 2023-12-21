using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(PlayerPrefsManager.GetLevel());
    }

    public void Levels()
    {
        SceneManager.LoadScene(1);
    }
}
