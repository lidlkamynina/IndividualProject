using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeAI : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _rotationSpeed;

    private Rigidbody _rigidbody;
    private PlayerAwarenessController _playerAwarenessController;
    private Vector3 _targetDirection;
    private float _changeDirectionCooldown;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _playerAwarenessController = GetComponent<PlayerAwarenessController>();
        _targetDirection = transform.forward; // Use forward direction for 3D movement
    }

    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotateTowardsTarget();
        SetVelocity();
    }

    private void UpdateTargetDirection()
    {
        HandleRandomDirectionChange();
        HandlePlayerTargeting();
    }

    private void HandleRandomDirectionChange()
    {
        _changeDirectionCooldown -= Time.deltaTime;

        if (_changeDirectionCooldown <= 0)
        {
            float angleChange = Random.Range(-90f, 90f);
            transform.Rotate(Vector3.up, angleChange); // Rotate around Y axis for 3D movement

            _changeDirectionCooldown = Random.Range(1f, 5f);
        }
    }

    private void HandlePlayerTargeting()
    {
        if (_playerAwarenessController.AwareOfPlayer)
        {
            _targetDirection = _playerAwarenessController.DirectionToPlayer.normalized;
        }
    }

    private void RotateTowardsTarget()
    {
        if (_targetDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(_targetDirection, Vector3.up); // Use LookRotation for 3D movement
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);
        }
    }

    private void SetVelocity()
    {
        _rigidbody.velocity = transform.forward * _speed; // Use forward direction for velocity in 3D
    }
}



    /*
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _rotationSpeed;

    private Rigidbody _rigidbody;
    private PlayerAwarenessController _playerAwarenessController;
    private Vector3 _targetDirection;
    private float _changeDirectionCooldown;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _playerAwarenessController = GetComponent<PlayerAwarenessController>();
        _targetDirection = transform.forward; // Use forward direction for 3D movement
    }

    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotateTowardsTarget();
        SetVelocity();
    }

    private void UpdateTargetDirection()
    {
        HandleRandomDirectionChange();
        HandlePlayerTargeting();
    }

    private void HandleRandomDirectionChange()
    {
        _changeDirectionCooldown -= Time.deltaTime;

        if (_changeDirectionCooldown <= 0)
        {
            float angleChange = Random.Range(-90f, 90f);
            transform.Rotate(Vector3.up, angleChange); // Rotate around Y axis for 3D movement

            _changeDirectionCooldown = Random.Range(1f, 5f);
        }
    }

    private void HandlePlayerTargeting()
    {
        if (_playerAwarenessController.AwareOfPlayer)
        {
            _targetDirection = _playerAwarenessController.DirectionToPlayer.normalized;
        }
    }

    private void RotateTowardsTarget()
    {
        Quaternion targetRotation = Quaternion.LookRotation(_targetDirection, Vector3.up); // Use LookRotation for 3D movement
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);
    }

    private void SetVelocity()
    {
        _rigidbody.velocity = transform.forward * _speed; // Use forward direction for velocity in 3D
    } */

