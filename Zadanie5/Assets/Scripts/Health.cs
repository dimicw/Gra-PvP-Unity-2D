using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private int maxHealth = 100;
    [SerializeField] public int damageDealt = 3;
    private float timeToRegen = 1f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToRegen)
        {
            timer = 0;
            Heal(1);
        }
    }

    public void Damage(int amount)
    {
        if (amount > 0)
        {
            this.health -= amount;

            if (health <= 0)
                Die();
        }
    }

    public void Heal(int amount)
    {
        if (amount > 0)
            if (health + amount >= maxHealth)
                health = maxHealth;
            else
                health += amount;
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
