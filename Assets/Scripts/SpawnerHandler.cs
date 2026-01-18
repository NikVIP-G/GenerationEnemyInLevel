using UnityEngine;

[RequireComponent (typeof(TimerSpawn))]

public class SpawnerHandler<T, N> : MonoBehaviour where T : Spawner<N> where N : SpawnedObject
{
    [SerializeField] private T _spawners;
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
        _spawners.Spawn();
    }
}
