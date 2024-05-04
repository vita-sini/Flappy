using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEnemy : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private BulletEnemy _bullet;

    public void Shoot()
    {
        Instantiate(_bullet, _shootPoint.position, Quaternion.identity);
    }
}
