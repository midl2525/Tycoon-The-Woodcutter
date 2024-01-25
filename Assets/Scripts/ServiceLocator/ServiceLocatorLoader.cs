using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ServiceLocatorLoader : MonoBehaviour
{
    private BankHolder _bankHolder;
    private void Awake()
    {
        _bankHolder = new BankHolder();

        Registers();
    }

    private void Registers()
    {
        ServiceLocator.Current.Register<BankHolder>(_bankHolder);
    }
}
