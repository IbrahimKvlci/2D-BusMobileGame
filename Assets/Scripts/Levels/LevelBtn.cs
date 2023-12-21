using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelBtn : MonoBehaviour
{
    private int _levelValue;

    public int LevelValue
    {
        get { return _levelValue; }
        set { _levelValue = value; }
    }

    public void Play()
    {
        SceneManager.LoadScene(_levelValue);
    }
}
