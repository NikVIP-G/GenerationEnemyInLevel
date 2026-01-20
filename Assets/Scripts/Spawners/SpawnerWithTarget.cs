using UnityEngine;

[RequireComponent (typeof(PoolSpawnedObject))]

public class SpawnerWithTarget : Spawner<SpawnedObject>
{
    [SerializeField] private Target _target;

    protected Target Target => _target;

    public override void Spawn(SpawnedObject spawnedObject)
    {
        base.Spawn(spawnedObject);
        @spawnedObject.SetTarget(Target);
    }
}
