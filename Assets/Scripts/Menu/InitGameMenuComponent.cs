using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InitGameMenuComponent : MonoBehaviour
{
    [SerializeField] public GameObject initMenu;
    private InputAction jumpAction;
    
    public void Start()
    {
        GameStateManager.OnGameInit.AddListener(() => initMenu.SetActive(true));
        GameStateManager.OnGameStart.AddListener(() => initMenu.SetActive(false));
        GameStateManager.OnGameOver.AddListener(() => initMenu.SetActive(false));
        
        GameStateManager.InitGame();
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    public void Update()
    {
        if (GameStateManager.IsInMenu() && jumpAction.WasPressedThisFrame())
            GameStateManager.StartGame();
    }
}