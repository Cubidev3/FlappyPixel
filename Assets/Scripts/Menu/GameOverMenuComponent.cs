using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameOverMenuComponent : MonoBehaviour
{
    [SerializeField] public GameObject gameOverMenu;
    private InputAction jumpAction;
    
    public void Start()
    {
        GameStateManager.OnGameInit.AddListener(() => gameOverMenu.SetActive(false));
        GameStateManager.OnGameStart.AddListener(() => gameOverMenu.SetActive(false));
        GameStateManager.OnGameOver.AddListener(() => gameOverMenu.SetActive(true));
        
        GameStateManager.InitGame();
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    public void Update()
    {
        if (GameStateManager.IsGameOver() && jumpAction.WasPressedThisFrame())
            GameStateManager.StartGame();
    }
}