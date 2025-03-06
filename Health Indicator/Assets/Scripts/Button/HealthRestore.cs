public class HealthRestore : EventHandler
{
    private const int _heal = 10;

    protected override void HandleAction()
    {
        Heal();
    }

    private void Heal()
    {
        _health.Heal(_heal);
    }
}
