using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bank : MonoBehaviour
{
    [SerializeField] private BankView _bankView;
    [SerializeField] private MoneyHolder _moneyHolder;
    
    private BankHolder _bankHolder;

    private void Start()
    {
        _bankHolder = ServiceLocator.Current.Get<BankHolder>();
    }

    public void DisplayTextMoney()
    {
        _bankView.DisplayTextMoney(_bankHolder.Money);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != Constants.Tags.PLAYER) return;
        _moneyHolder.SetMoney(_moneyHolder.GetMoney() + _bankHolder.Money);
        _bankHolder.Money = 0;
        DisplayTextMoney();
    }
}
