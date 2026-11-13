using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    public float moveSpeed = 5f;

    private Vector2 movementInput;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Esta función recibe el input del teclado automáticamente
    public void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        // 1. Convertir el movimiento normal a perspectiva isométrica
        Vector3 isometricMovement = new Vector3(
            movementInput.x - movementInput.y,
            (movementInput.x + movementInput.y) / 2f,
            0f
        );

        isometricMovement.Normalize();

        // 2. Mover al personaje respetando las físicas y paredes
        rb.linearVelocity = isometricMovement * moveSpeed;
    }
}
