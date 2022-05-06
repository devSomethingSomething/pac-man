using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int score;

    private void Start()
    {
        score = 0;
    }

    public static void IncreaseScore(int increaseAmount)
    {
        score += increaseAmount;
    }
}
