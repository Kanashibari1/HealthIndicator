using System.Collections;
using UnityEngine;

public class HealthSmoothBar : HealthView
{
    private Coroutine _�oroutine;
    private float _smoothSpeed = 0.3f;
    private int _currentValue;

    protected override void UpdateHealth(int currentValue)
    {
        _currentValue = currentValue;

        if (_�oroutine == null)
            _�oroutine = StartCoroutine(SmoothlyUpdate());
    }

    private IEnumerator SmoothlyUpdate()
    {
        float targetValue = _currentValue / (float)_health.MaxValue;

        while (Mathf.Approximately(_slider.value, targetValue) != true)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetValue, _smoothSpeed * Time.deltaTime);
            yield return null;
        }

        _�oroutine = null;
    }
}
