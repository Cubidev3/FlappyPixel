using System;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject gameOverMenu;

    private void Start()
    {
        startMenu.SetActive(true);
        gameOverMenu.SetActive(false);
    }

    public void EndGame()
    {
        startMenu.SetActive(false);
        gameOverMenu.SetActive(true);
    }
}
