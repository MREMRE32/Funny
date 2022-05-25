using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = .5f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        //y limit
        if (turn.y > 90)
        {
            turn.y = 90;
        }
        if (turn.y < -90)
        {
            turn.y = -90;
        }

        //x limit
        if (turn.x > 180)
        {
            turn.x = 180;
        }
        if (turn.x < -180)
        {
            turn.x = -180;
        }

        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }

}



    