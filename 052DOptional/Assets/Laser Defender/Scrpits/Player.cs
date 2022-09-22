using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    Vector2 rawInput;
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 delta = rawInput;
        transform.position += delta * moveSpeed * Time.deltaTime;
    }

    void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();
        
    }
}
