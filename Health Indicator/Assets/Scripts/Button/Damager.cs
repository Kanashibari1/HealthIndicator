using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Damager : EventHandler
{
    private const int _damage = 10;

    protected override void HandleAction()
    {
        Damage();
    }

    private void Damage()
    {
        _health.TakeDamage(_damage);
    }
}