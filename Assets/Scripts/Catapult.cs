using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private Transform _cargo;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _progectile;

    private Vector3 _startPositionForCargo;

    private void Start()
    {
        _startPositionForCargo = _cargo.position;
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.E))
            _rigidbody.isKinematic = false;


        if (Input.GetKeyUp(KeyCode.Space))
        {
            _rigidbody.isKinematic = true;
            _cargo.position = _startPositionForCargo;
        }

        if (Input.GetKeyUp(KeyCode.Q) && _rigidbody.isKinematic == true)
            _progectile.position = _spawnPoint.position;
    }
}
