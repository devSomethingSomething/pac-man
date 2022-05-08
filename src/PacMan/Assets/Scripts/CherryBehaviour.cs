using UnityEngine;

public class CherryBehaviour : MonoBehaviour
{
    private const int POINTS_VALUE = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HandlePacCollision(collision);
    }

    private void HandlePacCollision(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pac"))
        {
            enabled = false;

            gameObject.SetActive(false);

            GameManager.IncreaseScore(POINTS_VALUE);

            GameManager.DecreaseCherryCount();
        }
    }
}
