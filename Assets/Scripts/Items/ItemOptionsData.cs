using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ItemOptionsData", menuName = "ItemOptionsData")]
public class ItemOptionsData : ScriptableObject
{
    public Dictionary<int, ItemOptions> Options => _options.ToDictionary();

    [SerializeField] private DictionaryOptions _options;
}

[System.Serializable]
public class DictionaryOptions
{
    [SerializeField] private DictionaryOptionsItem[] _pricesItems;

    public Dictionary<int, ItemOptions> ToDictionary()
    {
        Dictionary<int, ItemOptions> dictionary = new Dictionary<int, ItemOptions>();

        foreach (var item in _pricesItems)
        {
            dictionary.Add(item.Level, item.ItemOptions);
        }

        return dictionary;
    }
}

[System.Serializable]
public class DictionaryOptionsItem
{
    public int Level;
    public ItemOptions ItemOptions;
}

[System.Serializable]
public class ItemOptions
{
    public int Price;
}
