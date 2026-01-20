using System;
using System.Collections;
using UnityEngine;

public class TimerSpawn : MonoBehaviour
{
    [SerializeField] private float _spawnTime = 2.0f;

    private Coroutine _coroutine;

    public event Action timerEnded;

    private void Start()
    {
        _coroutine = StartCoroutine(Counter());
    }

    private IEnumerator Counter()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(_spawnTime);
            timerEnded?.Invoke();
        }
    }
}
