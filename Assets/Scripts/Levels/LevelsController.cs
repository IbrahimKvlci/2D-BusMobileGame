using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsController : MonoBehaviour, ILevels
{
    [SerializeField] GameObject _levelsBtnPrefab;
    [SerializeField] GameObject _levelsContent;

    [SerializeField] int _levelsCount;



    private void Awake()
    {
        SetLevels(_levelsCount);
    }

    public void SetLevels(int levelsCount)
    {
        for (int i = 0; i < levelsCount; i++)
        {
            var level = Instantiate(_levelsBtnPrefab);
            level.GetComponent<LevelBtn>().LevelValue = i + 2;
            level.transform.SetParent(_levelsContent.transform);
            level.gameObject.transform.localScale = Vector3.one;
            level.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text=(i+1).ToString();
            if (level.GetComponent<LevelBtn>().LevelValue <= PlayerPrefsManager.GetMaxLevel())
            {
                level.GetComponent<Button>().interactable = true;
            }
        }

    }

    
}
