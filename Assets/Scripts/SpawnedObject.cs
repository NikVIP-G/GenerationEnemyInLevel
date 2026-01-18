using UnityEngine;

[RequireComponent (typeof(Rigidbody))]

public class SpawnedObject : MonoBehaviour 
{
    [SerializeField] private float _speed;

    public void SetDirection(float direction)
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, direction, transform.rotation.z);
    }

    private void Update()
    {
        transform.Translate( Vector3.forward * _speed * Time.deltaTime );
    }

}
