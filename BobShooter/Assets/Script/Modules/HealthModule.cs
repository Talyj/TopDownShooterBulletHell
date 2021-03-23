using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthModule : ScriptableObject
{
    public Image health;
    public float currentHealth;
    public float maxHealth;
    
    public void HealthImage(Image health)
    {
        this.health = health;
    }

    public void CurrentHealth(float currentHealth)
    {
        this.currentHealth = currentHealth;
    }

    public void MaxHealth(float maxHealth)
    {
        this.maxHealth = maxHealth;
    }

    public HealthModule(Image health, float currentHealth, float maxHealth)
    {
        this.health = health;
        this.currentHealth = currentHealth;
        this.maxHealth = maxHealth;
    }
}
