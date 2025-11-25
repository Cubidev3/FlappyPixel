using UnityEngine;
using TMPro;

public class ScoreUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = "Score: " + ScoreManager.GetScore();
        ScoreManager.OnScoreChanged.AddListener((score) => scoreText.text = "Score: " + score);
    }
}
