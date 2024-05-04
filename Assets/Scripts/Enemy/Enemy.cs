using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IInteractable
{
    [SerializeField] private float _delay = 3f;

    private WeaponEnemy _weapon;

    private void Awake()
    {
        _weapon = GetComponent<WeaponEnemy>();
    }

    private void Start()
    {
        StartCoroutine(GenerateBullets());
    }

    private IEnumerator GenerateBullets()
    {
        var wait = new WaitForSeconds(_delay);

        while (enabled)
        {
            _weapon.Shoot();
            yield return wait;
        }
    }
}
