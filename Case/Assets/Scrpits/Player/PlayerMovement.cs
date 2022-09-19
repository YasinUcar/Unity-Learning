using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] float speed;
    [SerializeField] private DynamicJoystick joystick;
    float horizontal, vertical;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {

        Movement(horizontal, vertical);
    }
    private void Movement(float horizontal, float vertical)
    {

        InputHorizontal();
        InputVertical();
        rigidbody.velocity = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;

    }
    void InputHorizontal()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            horizontal = Input.GetAxis("Horizontal");
        else if (Input.GetMouseButton(0))
            horizontal = joystick.Horizontal;
        else
        {
            horizontal = 0;
        }
    }
    void InputVertical()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            vertical = Input.GetAxis("Vertical");
        else if (Input.GetMouseButton(0))
            vertical = joystick.Vertical;
        else
        {
            vertical = 0;
        }
    }










}
