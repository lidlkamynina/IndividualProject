using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool IsGrounded { get; private set; }

    void Update()
    {
        // Perform raycast to check if the player is grounded
        IsGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);
    }
}