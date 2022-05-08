using TMPro;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{
    private static TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public static void UpdateScoreText(int score)
    {
        text.text = $"Score: {score}";
    }
}
