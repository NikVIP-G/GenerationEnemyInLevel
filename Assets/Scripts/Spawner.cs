using UnityEngine;

public class Spawner<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T _prefab;

    public virtual T Spawn()
    {
        T @object = Instantiate(_prefab, transform.position, Quaternion.identity);
        return @object;
    }
}
