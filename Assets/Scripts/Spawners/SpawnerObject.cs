using System;
using UnityEngine;

[Serializable]
public struct SpawnerObject
{
    [SerializeField] private SpawnerWithTarget _spawner;
    [SerializeField] private PoolSpawnedObject _pool;

    public SpawnerWithTarget Spawner => _spawner;
    public PoolSpawnedObject Pool => _pool;
}
