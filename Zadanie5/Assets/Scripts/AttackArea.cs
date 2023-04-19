using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage;

    void Awake()
    {
        damage = transform.GetComponentInParent<Health>().damageDealt;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Health>() != null)
            collider.GetComponent<Health>().Damage(damage);
    }
}
