using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float wallrunTime = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsTouchingWall())
        {
            wallrunTime = 0f;
            rb.velocity = new Vector3(rb.velocity.x, 5f, rb.velocity.z) + transform.forward * 5f;
        }

        if (IsTouchingWall())
        {
            wallrunTime += Time.deltaTime;

            if (wallrunTime >= 1.75f)
            {
                rb.AddForce(transform.forward * 5f, ForceMode.Impulse);
                wallrunTime = 0f;
            }
        }
    }

    private bool IsTouchingWall()
    {
        // Check if the player is colliding with a wall
        // Replace with appropriate check for your project
        return Physics.Raycast(transform.position, transform.forward, 0.5f);
    }
}
