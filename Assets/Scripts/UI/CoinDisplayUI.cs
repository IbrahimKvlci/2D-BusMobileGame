using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinDisplayUI : MonoBehaviour
{
    [SerializeField] TMP_Text _coinText;

    private void Start()
    {
        CollectibleManager.OnCoinValueChanged += CollectibleManager_OnCoinValueChanged;
    }

    void CollectibleManager_OnCoinValueChanged(int coinValue)
    {
        UpdateCoinUI(coinValue);
    }

    void UpdateCoinUI(int coinValue)
    {
        _coinText.text= coinValue.ToString();
    }
}
