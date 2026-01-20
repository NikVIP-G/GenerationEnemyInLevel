using System;
using UnityEngine;
using UnityEngine.Pool;

public class Pool <T> : MonoBehaviour where T : MonoBehaviour 
{
    [SerializeField] private T _prefab;
    [SerializeField] private int _poolCapacity = 5;
    [SerializeField] private int _poolMaxSize = 5;

    public Type PrefabType => _prefab.GetType();

    private ObjectPool<T> _pool;

    private void Awake()
    {
        _pool = new ObjectPool<T> (
        createFunc: () => Instantiate(_prefab),
        actionOnGet: (prefab) => prefab.gameObject.SetActive(true),
        actionOnRelease: (prefab) => prefab.gameObject.SetActive(false),
        actionOnDestroy: (prefab) => Destroy(prefab.gameObject),
        collectionCheck: true,
        defaultCapacity: _poolCapacity,
        maxSize: _poolMaxSize);
    }

    public T Get()
    {
        return _pool.Get();
    }

    public void Release(T @prefab)
    {
        _pool.Release(@prefab);
    }
}