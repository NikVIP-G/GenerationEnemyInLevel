using UnityEngine;

[RequireComponent (typeof(Rigidbody))]

public class SpawnedObject: MonoBehaviour
{
    [SerializeField] private float _speed;

    private Target _target;

    public void SetTarget(Target target)
    {
        _target = target;
    }

    private void Update()
    {
        transform.LookAt(_target.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }

}
