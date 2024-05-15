using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAwarenessController : MonoBehaviour
{
    public bool AwareOfPlayer { get; private set; }
    public Vector3 DirectionToPlayer { get; private set; } // Change Vector2 to Vector3

    [SerializeField]
    private float _playerAwarenessDistance;

    private Transform _player;

    private void Awake()
    {
        GameObject lizard = GameObject.FindWithTag("Player");
        if (lizard != null)
        {
            _player = lizard.transform;
        }
        else
        {
            Debug.LogError("Lizard object not found in the scene.");
        }
    }

    private void Update()
    {
        if (_player == null) return;

        Vector3 snakeToPlayerVector = _player.position - transform.position;
        DirectionToPlayer = snakeToPlayerVector.normalized;

        if (snakeToPlayerVector.magnitude <= _playerAwarenessDistance)
        {
            AwareOfPlayer = true;
        }
        else
        {
            AwareOfPlayer = false;
        }
    }
}
