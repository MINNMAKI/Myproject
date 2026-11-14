using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed = 5f;

    private Vector2 movementInput;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 isometricMovement = new Vector3(
            movementInput.x - movementInput.y,
            (movementInput.x + movementInput.y) / 2f,
            0f
        );
        isometricMovement.Normalize();
        rb.linearVelocity = isometricMovement * moveSpeed;
    }
}
