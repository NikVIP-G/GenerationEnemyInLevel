using UnityEngine;

public class BlueSpawnedObject : SpawnedObject 
{
    [SerializeField] private Renderer _rendere;

    private void Awake()
    {
        _rendere.material.color = Color.blue;
    }
}