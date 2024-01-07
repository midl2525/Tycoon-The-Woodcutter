using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgraderItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != Constants.Tags.ITEM_TAG) return;

        BaseItem baseItem = other.GetComponent<BaseItem>();

        baseItem.Level++;
        baseItem.UpdateLevelPrice();
        
    }
}
