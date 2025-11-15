using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] private BasicEnemyCube _basicEnemyPrefab;
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private float _repeatRate = 2.0f;
    [SerializeField] private int _height = 2;
    [SerializeField] private Vector3 _direction;
    private int _zero = 0;
    private int _quantityPoints;

    private void Start()
    {
        _quantityPoints = _spawnPoints.Count;
        StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        var wait = new WaitForSeconds(_repeatRate);

        while (true)
        {
            Spawn();
            yield return wait;
        }
    }

    private void Spawn()
    {
        int randomPoint = Random.Range(_zero, _quantityPoints);
        BasicEnemyCube EnemyPrefab = Instantiate(_basicEnemyPrefab, _spawnPoints[randomPoint].transform.position + new Vector3(0, _height, 0), gameObject.transform.rotation);
        EnemyPrefab.Initialize(_direction);
    }
}