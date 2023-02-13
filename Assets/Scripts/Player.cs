using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private MoveComponent moveComponent;

    private float speed = 5f;

    private float move;
    private bool jump;

    private void Start()
    {
        moveComponent = GetComponent<MoveComponent>();
    }

    private void Update()
    {
        move = Input.GetAxisRaw("Horizontal") * speed;
        jump = Input.GetButton("Jump");
        moveComponent.Move(move, jump);
    }
}