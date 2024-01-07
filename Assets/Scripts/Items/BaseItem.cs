using UnityEngine;
public abstract class BaseItem : MonoBehaviour
{
    public CustomPool<BaseItem> CustomPool { get; set; }

    public int Level;
    public int Price;

    [SerializeField] private ItemOptionsData _itemOptionsData;
    public abstract void Beginning();

    public void Spawn()
    {
        Level = 1;
        Price = _itemOptionsData.Options[Level].Price;
        Beginning();
    }

    public void UpdateLevelPrice()
    {
        if(_itemOptionsData.Options.ContainsKey(Level) == false) return;
        Price = _itemOptionsData.Options[Level].Price;
    }
}
