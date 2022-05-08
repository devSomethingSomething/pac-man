using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int score;

    private static int cherriesRemaining;

    [SerializeField]
    private Transform[] cherries;

    private void Start()
    {
        score = 0;

        cherriesRemaining = cherries.Length;
    }

    public static void IncreaseScore(int increaseAmount)
    {
        score += increaseAmount;

        ScoreBehaviour.UpdateScoreText(score);
    }

    public static void DecreaseCherryCount()
    {
        cherriesRemaining--;
    }
}
