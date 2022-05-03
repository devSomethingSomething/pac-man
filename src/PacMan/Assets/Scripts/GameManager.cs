using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Transform cherries;

    public static int Score;

    public static int RemainingCherries { get; private set; }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        Score = 0;

        RemainingCherries = cherries.childCount;
    }

    public static void DecreaseCherryCount(int decreaseAmount = 1)
    {
        RemainingCherries -= decreaseAmount;
    }

    public static bool CheckCherryCount()
    {
        return RemainingCherries <= 0 ? true : false;
    }
}
