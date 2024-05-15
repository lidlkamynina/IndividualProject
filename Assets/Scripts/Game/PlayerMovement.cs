using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private GroundCheck groundCheck;
    public float moveSpeed = 5f;
    public float maxVelocityY = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundCheck = GetComponent<GroundCheck>();
    }

    void Update()
    {
        HandleMovement();
        HandleJump();
    }

    void HandleMovement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * verticalInput * moveSpeed;

        movement.y = rb.velocity.y;

        rb.velocity = movement;
        rb.velocity = new Vector3(rb.velocity.x, Mathf.Clamp(rb.velocity.y, -maxVelocityY, maxVelocityY), rb.velocity.z);
    }

        void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (groundCheck.IsGrounded)
            {
                rb.velocity = new Vector3 (0, 5, 0);
            }
            else
            {
                Debug.Log("Not grounded - Cannot jump");
            }
    }
}
}