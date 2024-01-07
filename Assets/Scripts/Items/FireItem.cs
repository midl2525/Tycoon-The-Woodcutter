using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FireItem : BaseItem
{
    [SerializeField] private Rigidbody _rigidbody;

    public override void Beginning()
    {
        _rigidbody.velocity = Vector3.zero;
    }
}
