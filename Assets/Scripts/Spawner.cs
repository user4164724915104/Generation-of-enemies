using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private BasicEnemyCube _BasicEnemyPrefab;
    [SerializeField] private List<SpawnPoint> _SpawnPoints;
    [SerializeField] private float _delay = 0;
    [SerializeField] private float _repeatRate = 2.0f;
    private int _zero = 0;
    private int _quantityPoints;

    private void Start()
    {
        _quantityPoints = _SpawnPoints.Count;
        InvokeRepeating(nameof(RundomazePoint), _delay, _repeatRate);
    }

    private void RundomazePoint()
    {
        int randomPoint = Random.Range(_zero, _quantityPoints);
        _SpawnPoints[randomPoint].Spawn();
    }
}
