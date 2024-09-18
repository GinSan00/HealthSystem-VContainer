using UnityEngine;

public class HealthView : MonoBehaviour
{
    [SerializeField]
    public float Health { get; private set; }

    [SerializeField]
    public float MaxHealth { get; private set; }

    [SerializeField]
    public string HealthInfo { get => $"{Health}/{MaxHealth}"; }

    public void UpdateHealthUI(float health, float maxHealth)
    {
        Health = health;
        MaxHealth = maxHealth;
    }
}
