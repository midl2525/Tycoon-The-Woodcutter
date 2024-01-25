using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Remover : MonoBehaviour
{
    [SerializeField] private Bank _bank;

    private BankHolder _bankHolder;

    private void Start()
    {
        _bankHolder = ServiceLocator.Current.Get<BankHolder>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != Constants.Tags.ITEM) return;

        BaseItem baseItem = other.GetComponent<BaseItem>();

        baseItem.CustomPool.Release(baseItem);

        _bankHolder.Money += baseItem.Price;

        _bank.DisplayTextMoney();
    }
}
