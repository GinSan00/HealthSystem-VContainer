using System;
using System.Collections;
using UnityEngine;
using VContainer.Unity;

public class HealthService 
{
    private float _health = 10;
    private float _maxHealth = 100;

    public Action<float, float> OnHealthChanged;

    public void Damage(float value)
    {
        if (value > 0)
        {
            _health -= value;
            if (_health <= 0)
            {
                _health = 0;
            }
            OnHealthChanged?.Invoke(_health, _maxHealth);
        }
    }
    public void Heal(float value)
    {
        if (value > 0)
        {
            _health += value;
            if (_health > _maxHealth)
            {
                _health = _maxHealth;
            }
            OnHealthChanged?.Invoke(_health, _maxHealth);
        }
    }
}
