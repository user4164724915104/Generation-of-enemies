using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BasicEnemyCube : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Renderer _body;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _body.GetComponent<Renderer>().material.color = Color.red;
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.freezeRotation = true;
    }

    public void Initialize(Vector3 direction)
    {
        transform.LookAt(direction);
    }

    private void Update()
    {
        float moveChange = _moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveChange);
    }
}
