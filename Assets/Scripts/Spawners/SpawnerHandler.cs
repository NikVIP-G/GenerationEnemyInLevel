using System;
using UnityEngine;

[RequireComponent (typeof(TimerSpawn))]

public class SpawnerHandler : MonoBehaviour
{
    [SerializeField] private SpawnerObject[] _spawners;
    [SerializeField] private TimerSpawn _timerSpawn;

    private void OnEnable()
    {
        _timerSpawn.timerEnded += Spawn;
    }

    private void OnDisable()
    {
        _timerSpawn.timerEnded -= Spawn;
    }

    private void Spawn()
    {
        foreach (SpawnerObject spawner in _spawners)
        {
            SpawnedObject spawnedObject = spawner.Pool.Get();
            spawner.Spawner.Spawn(spawnedObject);
            spawnedObject.Collided += Release;
        }
    }

    private void Release(SpawnedObject @object)
    {
        foreach (SpawnerObject spawner in _spawners)
        {
            if (spawner.Pool.PrefabType == @object.GetType())
            {
                @object.Collided -= Release;
                spawner.Pool.Release(@object);
                @object.Reset();
                break;
            }
        }
    }
}
