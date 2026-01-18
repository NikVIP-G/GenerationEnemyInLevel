using UnityEngine;

public class SpawnerWithTarget<T> : Spawner<T> where T : SpawnedObject
{
    [SerializeField] private Target _target;

    protected Target Target => _target;

    public override T Spawn()
    {
        T @spawnedObject = base.Spawn();
        @spawnedObject.SetTarget(Target);
        return @spawnedObject;
    }
}
