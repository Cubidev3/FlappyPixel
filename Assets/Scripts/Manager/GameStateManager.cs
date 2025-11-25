using System;
using UnityEngine;
using UnityEngine.Events;

public enum GameState
{
    Menu,
    Game,
    GameOver
}

public class GameStateManager : MonoBehaviour
{
    public static UnityEvent OnGameInit = new();
    public static UnityEvent OnGameStart = new();
    public static UnityEvent OnGameOver = new();
    private static GameState currentState = GameState.Menu;

    public static void InitGame()
    {
        if (currentState == GameState.Menu)
            return;
        
        OnGameInit.Invoke();
        currentState = GameState.Menu;
    }

    public static void StartGame()
    {
        if (currentState != GameState.Menu)
            return;
        
        OnGameStart.Invoke();
        currentState = GameState.Game;
    }

    public static void EndGame()
    {
        if (currentState != GameState.Game)
            return;
        
        OnGameOver.Invoke();
        currentState = GameState.GameOver;
    }
    
    public static bool IsInMenu() => currentState == GameState.Menu;
    public static bool IsInGame() => currentState == GameState.Game;
    public static bool IsGameOver() =>  currentState == GameState.GameOver;
}
