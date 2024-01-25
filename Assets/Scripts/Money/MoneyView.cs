using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneyView : MonoBehaviour
{
    [SerializeField] private TMP_Text _textMoney;

    public void DisplayMoney(int money)
    {
        _textMoney.text = money + Constants.Symbols.MONEY;
    }
}
