using UnityEngine;

public class PipeScorerComponent : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreManager.IncrementScore();
        Destroy(this.gameObject);
    }
}
