using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;       // Speed of horizontal movement
    public float jumpForce = 10f;      // Force applied for jumping
    private Rigidbody2D rb;            // Reference to Rigidbody2D
    private Vector2 startPos;          // Store start position for respawn

    private bool isGrounded = false;   // Check if player is on the ground

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position; // Save starting position
    }

    void Update()
    {
        HandleMovement();
        HandleJump();
        HandleRespawn();
        if (transform.position.y < -10f)
        {
            Respawn();
        }
    }

    void HandleMovement()
    {
        float moveInput = Input.GetAxis("Horizontal"); // A/D or Left/Right arrows
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }

    void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false; // prevent double jump
        }
    }

    void Respawn() {
        transform.position = startPos;
        rb.linearVelocity = Vector2.zero;
    }


    void HandleRespawn()
    {
        if (Input.GetKeyDown(KeyCode.R)) // Press R to reset position
        {
            Respawn();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}