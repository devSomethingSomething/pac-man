using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DisablePac(collision);
    }

    private void DisablePac(Collider2D collision)
    {
        GameObject pac = collision.gameObject;

        if (pac.CompareTag("Pac") && GameManager.CanPassDoor())
        {
            pac.GetComponent<PacBehaviour>().enabled = false;

            pac.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            foreach (var collider in pac.GetComponents<Collider2D>())
            {
                collider.enabled = false;
            }

            WinBehaviour.EnableWinText();
        }
    }
}
