using UnityEngine;

public class DieToPipeComponent : MonoBehaviour
{
    private GameStateManager manager;

    private void Start()
    {
        manager = GameObject.FindWithTag("Manager").GetComponent<GameStateManager>();
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        manager.EndGame();
    }
}
