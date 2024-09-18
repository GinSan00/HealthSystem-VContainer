using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VContainer.Unity;

public class Health : IStartable
{
    readonly HealthService _healthService;
    readonly HealthView _healthView;

    public Health(HealthService healthService, HealthView healthView)
    {
        _healthService = healthService;
        _healthView = healthView;
    }

    void IStartable.Start()
    {
        _healthService.OnHealthChanged += _healthView.UpdateHealthUI;
        _healthService.Heal(20);
    }
}
