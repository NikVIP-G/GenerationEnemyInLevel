using UnityEngine;

[RequireComponent (typeof(TimerSpawn))]

public class SpawnHandlerWithDefineDirection : MonoBehaviour
{
    [SerializeField] private SpawnerWithDefineDirection[] _spawners;
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
        int randomIndexSpawner = Random.Range(0, _spawners.Length);
        _spawners[randomIndexSpawner].Spawn();
    }
}
