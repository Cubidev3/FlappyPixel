using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InitGameMenuComponent : MonoBehaviour
{
    private InputAction jumpAction;

    private void Awake()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    public void Update()
    {
        Time.timeScale = 0f;
        if (jumpAction.WasPressedThisFrame())
        {
            Time.timeScale = 1f;
            this.gameObject.SetActive(false);
        }
    }
}
