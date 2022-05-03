using UnityEngine;

public class PelletBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);

        GameManager.Score++;
    }
}
