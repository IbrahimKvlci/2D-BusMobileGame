using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class PlayerPrefsManager
{
    private static string _level = "level";
    private static string _maxLevel = "maxlevel";
    private static string _coin = "coin";


    public static void SetPlayerLevel(int level)
    {
        Debug.Log($"{level} {SceneManager.sceneCountInBuildSettings}");
        if (level < SceneManager.sceneCountInBuildSettings)
        {
            Debug.Log("yes");
            PlayerPrefs.SetInt(_level, level);
            SetMaxLevel(level);
        }
        else
        {
            PlayerPrefs.SetInt(_level, 0);
        }
    }
    
    public static void SetMaxLevel(int level)
    {
        if (PlayerPrefs.GetInt(_maxLevel) < level)
        {
            PlayerPrefs.SetInt(_maxLevel, level);
        }
    }

    public static void SetCoin(int coin)
    {
        PlayerPrefs.SetInt(_coin,coin);
    }

    public static int GetLevel()
    {
        return PlayerPrefs.GetInt(_level,2);
    }

    public static int GetMaxLevel()
    {
        return PlayerPrefs.GetInt(_maxLevel, 2);
    }

    public static int GetCoin()
    {
        return PlayerPrefs.GetInt(_coin);
    }
}
