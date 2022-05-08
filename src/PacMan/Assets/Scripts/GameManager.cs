using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int score;

    private static int cherriesRemaining;

    [SerializeField]
    private Transform cherries;

    [SerializeField]
    private Collider2D door;

    private void Start()
    {
        score = 0;

        cherriesRemaining = cherries.childCount;
    }

    private void Update()
    {
        if (cherriesRemaining <= 0)
        {
            door.isTrigger = true;
        }
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
