using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    [SerializeField] HealthView _healthView;
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<Health>();
        builder.Register<HealthService>(Lifetime.Singleton);
        builder.RegisterComponent(_healthView);
    }
}
