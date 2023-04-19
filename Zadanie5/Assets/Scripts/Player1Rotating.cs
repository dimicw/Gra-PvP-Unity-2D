using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Rotating : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.D))
            transform.eulerAngles = new Vector3(0, 0, 45);
        else if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.D))
            transform.eulerAngles = new Vector3(0, 0, 315);
        else if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.A))
            transform.eulerAngles = new Vector3(0, 0, 135);
        else if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.A))
            transform.eulerAngles = new Vector3(0, 0, 225);
        else if (Input.GetKeyDown(KeyCode.W))
            transform.eulerAngles = new Vector3(0, 0, 90);
        else if (Input.GetKeyDown(KeyCode.S))
            transform.eulerAngles = new Vector3(0, 0, 180);
        else if (Input.GetKeyDown(KeyCode.A))
            transform.eulerAngles = new Vector3(0, 0, 270);
        else if (Input.GetKeyDown(KeyCode.D))
            transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
