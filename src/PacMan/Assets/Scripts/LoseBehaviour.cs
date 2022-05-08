using TMPro;
using UnityEngine;

public class LoseBehaviour : MonoBehaviour
{
    private static TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public static void EnableLoseText()
    {
        text.enabled = true;
    }
}
