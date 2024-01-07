using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Remover : MonoBehaviour
{
    private HolderBank _holderBank;

    private void Start()
    {
        _holderBank = ServiceLocator.Current.Get<HolderBank>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != Constants.Tags.ITEM_TAG) return;

        BaseItem baseItem = other.GetComponent<BaseItem>();

        baseItem.CustomPool.Release(baseItem);

        _holderBank.Money += baseItem.Price;

        ServiceLocator.Current.Get<Bank>().DisplayTextMoney();
    }
}
