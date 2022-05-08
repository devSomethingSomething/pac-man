using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int score;

    private static int cherriesRemaining;

    [SerializeField]
    private Transform cherries;

    private void Start()
    {
        score = 0;

        cherriesRemaining = cherries.childCount;
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

    public static bool CanPassDoor()
    {
        if (cherriesRemaining <= 0)
        {
            return true;
        }

        return false;
    }
}
