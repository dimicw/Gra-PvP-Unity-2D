using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Attack : MonoBehaviour
{
    private GameObject area = default;
    private bool attacking = false;
    private float timeToAttack = 0.25f;
    private float timer = 0f;

    void Start()
    {
        area = transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
            Attack();
        if (attacking)
        {
            timer += Time.deltaTime;
            if (timer >= timeToAttack)
            {
                timer = 0;
                area.transform.localScale = new Vector3(0f, 0f, 0f);
                attacking = false;
                area.SetActive(attacking);
            }
        }
    }

    private void Attack()
    {
        area.transform.localScale = new Vector3(1f, 1f, 1f);
        attacking = true;
        area.SetActive(attacking);
    }
}
