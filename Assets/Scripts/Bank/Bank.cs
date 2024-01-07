using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bank : MonoBehaviour, IService
{
    [SerializeField] private BankView _bankView;

    private HolderMoney _holderMoney;
    private HolderBank _holderBank;

    private void Awake()
    {
        ServiceLocator.Current.Register<Bank>(this);
    }

    private void Start()
    {
        _holderMoney = ServiceLocator.Current.Get<HolderMoney>();
        _holderBank = ServiceLocator.Current.Get<HolderBank>();
    }

    public void DisplayTextMoney()
    {
        _bankView.DisplayTextMoney(_holderBank.Money);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != Constants.Tags.PLAYER_TAG) return;
        _holderMoney.Money += _holderBank.Money;
        _holderBank.Money = 0;
        DisplayTextMoney();
    }
}
