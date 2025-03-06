using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] protected Health _health;

    protected Slider _slider;
    protected TextMeshProUGUI _healthText;

    private void Awake()
    {
        _healthText = GetComponent<TextMeshProUGUI>();
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _health.ValueChanged += UpdateHealth;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= UpdateHealth;
    }

    protected abstract void UpdateHealth(int currentValue);
}
