using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1;
    public int scorePlayer2;
    public ScoreText scoreTextLeft;
    public ScoreText scoreTextRight;

    public void OnScoreZoneRaached(int id)
    {
        if (id == 1)
        {
            scorePlayer1 += 1;
        }
        if (id == 2)
        {
            scorePlayer2 += 1;
        }
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        scoreTextLeft.SetScore(scorePlayer1);
        scoreTextRight.SetScore(scorePlayer2);
    }
}
