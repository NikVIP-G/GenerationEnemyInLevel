using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnHandlerWithDefineDirection : MonoBehaviour
{
    [SerializeField] private SpawnerWithDefineDirection[] _spawners;
    [SerializeField] private float _spawnTime = 2.0f;

    private float _timer = 0.0f;

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _spawnTime)
        {
            int randomIndexSpawner = Random.Range(0, _spawners.Length);
            _spawners[randomIndexSpawner].Spawn();
            _timer = 0.0f;
        }
    }
}
