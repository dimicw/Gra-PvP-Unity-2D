using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private float speed = 5.0f;
    private Rigidbody2D body;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += transform.up * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.position -= transform.up * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= transform.right * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.position += transform.right * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.T)) GetComponent<Health>().Damage(30);
    }
}
