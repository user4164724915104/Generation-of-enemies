using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private BasicEnemyCube _BasicEnemyPrefab;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private int _height = 2;
    private Vector3 _position;

    private void Start()
    {
        _position = transform.position;
    }

    public void Spawn()
    {
        BasicEnemyCube EnemyPrefab = Instantiate(_BasicEnemyPrefab, _position + new Vector3(0, _height, 0), gameObject.transform.rotation);
        EnemyPrefab.Initialize(_direction);
    }
}
