using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mover))]
[RequireComponent(typeof(CollisionHandler))]

public class SpaceShip : MonoBehaviour
{
    private Weapon _weapon;
    private Mover _mover;
    private CollisionHandler _handler;

    public event Action GameOver;

    private void Awake()
    {
        _handler = GetComponent<CollisionHandler>();
        _mover = GetComponent<Mover>();
        _weapon = GetComponent<Weapon>();
    }

    private void OnEnable()
    {
        _handler.CollisionDetected += ProcessCollision;
    }

    private void OnDisable()
    {
        _handler.CollisionDetected -= ProcessCollision;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _weapon.Shoot();
        }
    }

    private void ProcessCollision(IInteractable interactable)
    {
        if (interactable is Enemy)
        {
            GameOver?.Invoke();
        }

        else if (interactable is Ground)
        {
            GameOver?.Invoke();
        }

        else if (interactable is BulletEnemy)
        {
            GameOver?.Invoke();
        }
    }

    public void Reset()
    {
        _mover.Reset();
    }
}
