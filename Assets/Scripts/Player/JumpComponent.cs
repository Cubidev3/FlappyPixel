using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpComponent : MonoBehaviour
{
    [SerializeField] private float jumpImpulse = 6;

    private Rigidbody2D rigidbody;
    private InputAction jumpAction;

    private bool wantsToJump;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    private void Update()
    {
        wantsToJump = jumpAction.WasPressedThisFrame();
    }

    private void FixedUpdate()
    {
        if (wantsToJump)
        {
            rigidbody.linearVelocity = Vector2.zero;
            rigidbody.AddForceY(jumpImpulse, ForceMode2D.Impulse);
            wantsToJump = false;
        }
    }
}
