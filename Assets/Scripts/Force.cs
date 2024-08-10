using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Force : MonoBehaviour
{
    [SerializeField] private Rigidbody _swing;
    [SerializeField] private int _value = 3;

    private void OnMouseDown()
    {
        _swing.AddForce(0, 0, _value, ForceMode.Impulse);
    }
}
