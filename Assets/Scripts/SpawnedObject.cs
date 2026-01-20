using System;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]

public class SpawnedObject: MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Color _color;

    private Target _target;

    public event Action<SpawnedObject> Collided;

    private void Awake()
    {
        _renderer.material.color = _color;
    }

    private void Update()
    {
        transform.LookAt(_target.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Target>(out _))
            Collided?.Invoke(this);
    }

    public void Reset()
    {
        _rigidbody.velocity = Vector3.zero;
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }
}
