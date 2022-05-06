using UnityEngine;

public class PacBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private float angle;

    private new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        HandleInput("Horizontal", Vector2.right);
        HandleInput("Vertical", Vector2.up);
    }

    private void HandleInput(string axisName, Vector2 direction)
    {
        if (Input.GetAxisRaw(axisName) != .0f)
        {
            rigidbody2D.velocity = direction * Input.GetAxisRaw(axisName) * speed;

            SetRotation();
        }
    }

    private void SetRotation()
    {
        angle = Mathf.Atan2(rigidbody2D.velocity.y, rigidbody2D.velocity.x);

        transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);
    }
}
