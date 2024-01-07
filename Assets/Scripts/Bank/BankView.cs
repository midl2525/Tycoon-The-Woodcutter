using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BankView : MonoBehaviour
{
    [SerializeField] private TMP_Text _textMoney;

    public void DisplayTextMoney(int money)
    {
        _textMoney.text = money + Constants.Symbols.MONEY_SYMBOL;
    }
}
