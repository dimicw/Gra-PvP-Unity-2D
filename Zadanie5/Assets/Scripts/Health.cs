using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private int maxHealth = 100;
    [SerializeField] public int damageDealt = 7;
    [SerializeField] private int healing = 1;
    [SerializeField] private float timeToHeal = 1.5f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToHeal)
        {
            timer = 0;
            Heal(healing);
        }
    }

    public void Damage(int amount)
    {
        if (amount > 0)
        {
            this.health -= amount;
            GetComponentInParent<HealthBar>().SetHp(health);

            if (health <= 0)
                Die();
        }
    }

    public void Heal(int amount)
    {
        if (amount > 0)
        {
            if (health + amount >= maxHealth)
                health = maxHealth;
            else
                health += amount;
            GetComponentInParent<HealthBar>().SetHp(health);
        }
    }

    private void Die()
    {
        if (GetComponentInParent<BlueMovement>() != null)
            GetComponentInParent<BlueMovement>().enabled = false;
        else if (GetComponentInParent<RedMovement>() != null)
            GetComponentInParent<RedMovement>().enabled = false;

        GetComponentInParent<Animator>().SetTrigger("Death");
    }
}
