using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private Text resultScoreText;

    void Start()
    {
        if (ScoreManager.Instance != null && resultScoreText != null)
        {
            int score = ScoreManager.Instance.GetScore();
            resultScoreText.text = "Final Score: " + score.ToString();
        }
    }
}
