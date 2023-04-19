using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    private float speed = 5.0f;
    //private Rigidbody2D body;

    void Awake()
    {
        //body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        /*if (Input.GetKey(KeyCode.W))
            transform.position += transform.up * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            transform.position -= transform.up * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.A))
            transform.position -= transform.right * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * speed * Time.deltaTime;*/

        if (Input.GetKey(KeyCode.W))
            transform.position = new Vector3(transform.position.x, transform.position.y * speed * Time.deltaTime);
    }
}
