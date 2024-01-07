using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UpgraderView : MonoBehaviour
{
    [SerializeField] private TMP_Text _textName;
    [SerializeField] private TMP_Text _textPrice;

    public void DisplayTexts(string text, int count)
    {
        _textName.text = text;
        _textPrice.text = count + Constants.Symbols.MONEY_SYMBOL;
    }
}
