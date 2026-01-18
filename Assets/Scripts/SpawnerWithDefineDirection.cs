using UnityEngine;

public class SpawnerWithDefineDirection : Spawner <SpawnedObject> 
{
    [SerializeField] private float _direction;

    private float _minRotation = 0.0f;
    private float _maxRotation = 360f;

    private void Start()
    {
        if (_direction == _minRotation)
            _direction = UnityEngine.Random.Range(_minRotation, _maxRotation);
    }

    public override SpawnedObject Spawn()
    {
        SpawnedObject spawnedObject = base.Spawn();
        spawnedObject.SetDirection(_direction);
        return spawnedObject;
    }
}