using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyHolder : MonoBehaviour, IService
{
    [SerializeField] private MoneyView _moneyView;

    private int _money;

    private void Start()
    {
        Load();
        _moneyView.DisplayMoney(_money);
    }

    public void SetMoney(int count)
    {
        _money = count;
        Save();
        _moneyView.DisplayMoney(_money);
    }

    public int GetMoney()
    {
        return _money;
    }

    private void Save()
    {
        PlayerPrefs.SetInt(Constants.SaveNames.MONEY, _money);
    }

    private void Load()
    {
        _money = PlayerPrefs.GetInt(Constants.SaveNames.MONEY);
    }

}
