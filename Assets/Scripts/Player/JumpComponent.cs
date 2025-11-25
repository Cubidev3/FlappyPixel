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
        wantsToJump = false;
    }

    private void Update()
    {
        wantsToJump = jumpAction.WasPressedThisFrame();
    }

    private void FixedUpdate()
    {
        rigidbody.gravityScale = GameStateManager.IsInGame() ? 1 : 0;

        if (wantsToJump)
        {
            rigidbody.linearVelocity = Vector2.zero;
            rigidbody.AddForceY(jumpImpulse, ForceMode2D.Impulse);
            wantsToJump = false;
        }
    }
}
