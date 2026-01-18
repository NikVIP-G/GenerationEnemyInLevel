using UnityEngine;

public class GreenSpawnedObject : SpawnedObject
{
    [SerializeField] private Renderer _rendere;

    private void Awake()
    {
        _rendere.material.color = Color.green;
    }
}