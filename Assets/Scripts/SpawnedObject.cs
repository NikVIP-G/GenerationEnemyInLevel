using UnityEngine;

[RequireComponent (typeof(Rigidbody))]

public class SpawnedObject : MonoBehaviour 
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate( Vector3.forward * _speed * Time.deltaTime );
    }
}
