using UnityEngine;

public class RedSpawnedObject : SpawnedObject
{
    [SerializeField] private Renderer _rendere;

    private void Awake()
    {
        _rendere.material.color = Color.red;
    }
}