using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _tmp;

    private void OnValidate()
    {
        _tmp = GetComponentInChildren<TextMeshProUGUI>();
    }

    void Start()
    {
        GameManager.OnChangeCoin += OnChangeCoin;
        OnChangeCoin();
    }

    private void OnChangeCoin(int obj)
    {
        OnChangeCoin();
    }

    private void OnChangeCoin()
    {
        _tmp.SetText($"{GameDataManager.Instance.playerData.intDiamond} <sprite=0>");
    }
}