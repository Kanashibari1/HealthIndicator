public class HealthBar : HealthView
{
    protected override void UpdateHealth(int currentValue)
    {
        _slider.value = currentValue / (float)_health.MaxValue;
    }
}
