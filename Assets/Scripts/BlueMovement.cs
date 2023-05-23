using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMovement : MonoBehaviour
{

    private float speed = 1f;
    private GameObject weaponAxis = default;
    public bool isAttacking = false;
    public Animator animator;

    void Awake()
    {
        weaponAxis = transform.GetChild(0).gameObject;
    }

    void Update()
    {
        bool isWalking = false;

        if (!isAttacking)
        {
            animator.SetBool("isAttacking", false);
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetFloat("Y", 1f);
                animator.SetFloat("X", 0f);
                isWalking = true;

                weaponAxis.transform.eulerAngles = new Vector3(0, 0, 180f);
                transform.position += transform.up * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                animator.SetFloat("Y", -1f);
                animator.SetFloat("X", 0f);
                isWalking = true;

                weaponAxis.transform.eulerAngles = new Vector3(0, 0, 0f);
                transform.position -= transform.up * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                animator.SetFloat("Y", 0f);
                animator.SetFloat("X", -1f);
                isWalking = true;

                weaponAxis.transform.eulerAngles = new Vector3(0, 0, 270f);
                transform.position -= transform.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                animator.SetFloat("Y", 0f);
                animator.SetFloat("X", 1f);
                isWalking = true;

                weaponAxis.transform.eulerAngles = new Vector3(0, 0, 90f);
                transform.position += transform.right * speed * Time.deltaTime;
            }

            animator.SetBool("isWalking", isWalking);
        }
        else animator.SetBool("isAttacking", true);
    }
}
