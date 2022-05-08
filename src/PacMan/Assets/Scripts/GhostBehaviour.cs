using UnityEngine;

enum Direction
{
    Horizontal,
    Vertical,
    Diagonal
}

public class GhostBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Direction direction;

    private new Rigidbody2D rigidbody2D;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        SetStartingVelocity();
    }

    private void Update()
    {
        SetSpriteDirection();
    }

    private void SetStartingVelocity()
    {
        switch (direction)
        {
            case Direction.Horizontal:
                rigidbody2D.velocity = Vector2.right * speed;
                rigidbody2D.constraints = RigidbodyConstraints2D.FreezePositionY;
                break;
            case Direction.Vertical:
                rigidbody2D.velocity = Vector2.up * speed;
                rigidbody2D.constraints = RigidbodyConstraints2D.FreezePositionX;
                break;
            case Direction.Diagonal:
                rigidbody2D.velocity = (Vector2.right + Vector2.up) * speed;
                break;
        }
    }

    private void SetSpriteDirection()
    {
        if (rigidbody2D.velocity.x < 0)
        {
            spriteRenderer.flipX = true;
            return;
        }

        spriteRenderer.flipX = false;
    }
}
