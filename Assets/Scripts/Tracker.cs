using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    [SerializeField] private SpaceShip _spaceShip;
    [SerializeField] private float _xOffset;

    private void Update()
    {
        var position = transform.position;
        position.x = _spaceShip.transform.position.x + _xOffset;
        transform.position = position;
    }
}
