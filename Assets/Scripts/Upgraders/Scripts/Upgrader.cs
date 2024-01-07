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

    private void Start()
    {
        _upgraderView.DisplayTexts(_name, _price);
    }

    private void OnTriggerEnter(Collider other)
    {
        HolderMoney holderMoney = ServiceLocator.Current.Get<HolderMoney>();

        if (other.tag != Constants.Tags.PLAYER_TAG) return;

        if (holderMoney.Money < _price) return;

        holderMoney.Money -= _price;

        foreach (var item in _objects)
        {
            item.SetActive(true);
        }

        Destroy(_upgrader);
    }
}
