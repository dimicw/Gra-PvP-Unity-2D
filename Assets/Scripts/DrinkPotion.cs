using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkPotion : MonoBehaviour
{
    [SerializeField] private int healing = 35;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Health>() != null)
        {
            collider.GetComponent<Health>().Heal(healing);
            gameObject.SetActive(false);
        }
    }
}
