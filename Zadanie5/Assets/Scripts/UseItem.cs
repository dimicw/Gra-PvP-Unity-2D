using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    [SerializeField] bool Destroyable = false;
    private bool alreadyUsed = false;
    public Animator animator;

    public void Activate()
    {
        animator.SetBool("Used", true);
        if (!alreadyUsed)
        {
            if (Destroyable)
                this.GetComponent<CircleCollider2D>().isTrigger = true;
            if (transform.GetChild(0) != null)
                transform.GetChild(0).gameObject.SetActive(true);
            alreadyUsed = true;
        }
    }
}
