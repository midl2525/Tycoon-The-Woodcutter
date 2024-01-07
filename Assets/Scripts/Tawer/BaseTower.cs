using UnityEngine;
public abstract class BaseTower : MonoBehaviour
{
    [SerializeField] private protected Transform _spawnPoint;
    [SerializeField] private protected BaseItem _prefabItem;

    [SerializeField] private protected float _delaySpawnItem;

    private protected CustomPool<BaseItem> _customPool;

    public void SpawnItem()
    {
        BaseItem item;
        item = _customPool.Get();
        item.CustomPool = _customPool;
        item.transform.position = _spawnPoint.position;
        item.Spawn();
    }
}
