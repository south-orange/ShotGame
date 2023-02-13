using System;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rbody;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    public void Move(float move, bool jump)
    {
        rbody.velocity = new Vector2(move, rbody.velocity.y);

        if (jump)
        {
            rbody.AddForce(new Vector2(0, speed));
        }
    }
}