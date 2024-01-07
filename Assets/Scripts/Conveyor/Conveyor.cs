using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Conveyor : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private EDirectionConveyor _directionConveyor;

    [SerializeField] private Rigidbody _rigidbody;

    private void FixedUpdate()
    {
        Movements();
    }

    private void Movements()
    {
        Vector3 position = _rigidbody.position;
        switch (_directionConveyor)
        {
            case EDirectionConveyor.left:
                _rigidbody.position += Vector3.left * _speed;
                break;
            case EDirectionConveyor.right:
                _rigidbody.position += Vector3.right * _speed;
                break;
            case EDirectionConveyor.back:
                _rigidbody.position += Vector3.back * _speed;
                break;
            case EDirectionConveyor.up:
                _rigidbody.position += Vector3.up * _speed;
                break;
            default:
                break;
        }
        _rigidbody.MovePosition(position);
    }
}
