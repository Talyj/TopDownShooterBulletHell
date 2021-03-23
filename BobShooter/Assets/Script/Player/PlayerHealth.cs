using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Image health;
    public float currentHealth;
    public float maxHealth;

    List<ScriptableObject> Modules;
    public HealthModule healthComponent;

    void Start()
    {
        healthComponent = new HealthModule(health, currentHealth, maxHealth);

        Modules = new List<ScriptableObject>();
        Modules.Add(healthComponent);
        TAccessor<HealthModule>.Instance().Add(healthComponent);
    }

    
    void Update()
    {
        health.fillAmount = currentHealth / maxHealth;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
    }
}
