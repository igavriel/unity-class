using UnityEngine;

public static class ScoreManager
{
    public static int Score { get; private set; } = 0;

    public static int HighScore { get; private set; } = 0;

    public static bool PauseGame { get; set; } = false;

    public static void ResetScore()
    {
        Score = 0;
    }

    public static void AddScore(int value)
    {
        Score += value;
        if (Score > HighScore)
        {
            HighScore = Score;
        }
        Debug.Log($"Score is {Score}");
    }
}
