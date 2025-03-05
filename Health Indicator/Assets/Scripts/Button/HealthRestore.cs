public class HealthRestore : Handler
{
    private const int _heal = 10;

    protected override void DamageOrHeal()
    {
        _health.Heal(_heal);
    }
}
