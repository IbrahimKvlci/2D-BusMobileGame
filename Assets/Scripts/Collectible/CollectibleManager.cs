using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour, ICollectibleService
{
    [SerializeField] int _coinCount;

    public int CoinCount
    {
        get { return _coinCount; }
        set { _coinCount = value; }
    }

    public static Action<int> OnCoinValueChanged;

    public static CollectibleManager Instance { get; private set; }

    private void Start()
    {
        Instance = this;
    }

    public void CollectCoin()
    {
        CoinCount++;
        OnCoinValueChanged?.Invoke(CoinCount);
    }
}
