using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PausePanelUI : MonoBehaviour
{
    [SerializeField] TMP_Text _coinText;
    

    private void Start()
    {
        SetCoinText();
    }

    void SetCoinText()
    {
        _coinText.text = CollectibleManager.Instance.CoinCount.ToString();
    }

}
