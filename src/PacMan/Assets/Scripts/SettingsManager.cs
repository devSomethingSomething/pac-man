using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    private const int TARGET_FRAME_RATE = 60;

    private void Start()
    {
        Application.targetFrameRate = TARGET_FRAME_RATE;
    }
}
