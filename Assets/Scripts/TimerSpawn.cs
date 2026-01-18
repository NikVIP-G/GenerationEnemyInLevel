using System;
using System.Collections;
using UnityEngine;

public class TimerSpawn : MonoBehaviour
{
    [SerializeField] private float _spawnTime = 2.0f;

    private Coroutine _coroutine;
    private bool _isEnded = true;

    public event Action timerEnded;

    private void Update()
    {
        if (_isEnded)
        {
            _isEnded = false;
            _coroutine = StartCoroutine(Counter());
        }
    }

    private IEnumerator Counter()
    {
        yield return new WaitForSeconds(_spawnTime);
        StopCoroutine(_coroutine);
        timerEnded?.Invoke();
        _isEnded = true;
    }
}
