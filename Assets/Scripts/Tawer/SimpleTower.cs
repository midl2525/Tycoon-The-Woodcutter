using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SimpleTower : BaseTower
{
    private void Start()
    {
        _customPool = new CustomPool<BaseItem>(_prefabItem, 5);
        StartCoroutine(SpawnItemCoroutine());
    }

    private IEnumerator SpawnItemCoroutine()
    {
        while (true)
        {
            SpawnItem();
            yield return new WaitForSecondsRealtime(_delaySpawnItem);
        }
    }
}
