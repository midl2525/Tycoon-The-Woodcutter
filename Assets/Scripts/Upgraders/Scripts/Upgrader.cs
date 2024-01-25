using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrader : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private int _price;
    [SerializeField] private List<GameObject> _objects;

    [SerializeField] private GameObject _upgrader;
    [SerializeField] private UpgraderView _upgraderView;

    [SerializeField] private MoneyHolder _moneyHolder;

    private void Start()
    {
        _upgraderView.DisplayTexts(_name, _price);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != Constants.Tags.PLAYER) return;

        if (_moneyHolder.GetMoney() < _price) return;

        _moneyHolder.SetMoney(_moneyHolder.GetMoney() - _price);

        foreach (var item in _objects)
        {
            item.SetActive(true);
        }

        Destroy(_upgrader);
    }
}
