using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public static UnityEvent<int> OnScoreChanged = new();
    private static int score = 0;

    private void Awake()
    {
        score = 0;
    }

    public static void IncrementScore()
    {
        score++;
        OnScoreChanged.Invoke(score);
    }

    public static int GetScore() => score;
}
