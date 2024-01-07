using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ServiceLocatorLoader : MonoBehaviour
{
    private HolderMoney _holderMoney;
    private HolderBank _holderBank;

    private void Awake()
    {
        _holderMoney = new HolderMoney();
        _holderBank = new HolderBank();

        Registers();
    }

    private void Registers()
    {
        ServiceLocator.Current.Register<HolderMoney>(_holderMoney);
        ServiceLocator.Current.Register<HolderBank>(_holderBank);
    }
}
