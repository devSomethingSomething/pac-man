using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinBehaviour : MonoBehaviour
{
    private static TextMeshProUGUI text;

    private static bool roundOver;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();

        roundOver = false;
    }

    private void Update()
    {
        ReloadScene();
    }

    public static void EnableWinText()
    {
        text.enabled = true;

        roundOver = true;
    }

    private void ReloadScene()
    {
        if (Input.GetKeyDown(KeyCode.R) && roundOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
