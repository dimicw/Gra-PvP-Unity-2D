using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueAttack : MonoBehaviour
{
    private GameObject weapon = default;
    private bool attacking = false;
    private float timeToAttack = 0.25f;
    private float timer = 0f;

    void Start()
    {
        weapon = transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Attack();
        if (attacking)
        {
            timer += Time.deltaTime;
            if (timer >= timeToAttack)
            {
                timer = 0;
                attacking = false;
                transform.GetComponentInParent<BlueMovement>().isAttacking = attacking;
                weapon.SetActive(attacking);
            }
        }
    }

    private void Attack()
    {
        attacking = true;
        transform.GetComponentInParent<BlueMovement>().isAttacking = attacking;
        weapon.SetActive(attacking);
    }
}
