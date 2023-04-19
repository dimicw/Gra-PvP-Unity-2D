using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    private float speed = 1.0f;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.W))
            body.velocity += new Vector2(Time.deltaTime * speed, body.velocity.y);
        else if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * Time.deltaTime * speed;
        else if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * Time.deltaTime * speed;
        else if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * Time.deltaTime * speed;*/
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.up * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            transform.position -= transform.up * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.A))
            transform.position -= transform.right * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * speed * Time.deltaTime;
    }
}
