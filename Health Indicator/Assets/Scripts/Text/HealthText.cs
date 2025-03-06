using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class HealthText : HealthView
{
    private void Start()
    {
        UpdateHealth(_health.CurrentValue);
    }

    protected override void UpdateHealth(int currentValue)
    {
        _healthText.text = $"{_health.CurrentValue}/{_health.MaxValue}";
    }
}
