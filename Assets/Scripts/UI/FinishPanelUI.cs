using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishPanelUI : MonoBehaviour
{
    [SerializeField] TMP_Text _coinCount;

    private void Start()
    {
        SetCoinText();
    }

    void SetCoinText()
    {
        _coinCount.text = CollectibleManager.Instance.CoinCount.ToString();
    }
}
