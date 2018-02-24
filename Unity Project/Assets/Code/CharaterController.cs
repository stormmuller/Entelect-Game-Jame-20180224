using UnityEngine;

public class CharaterController : MonoBehaviour 
{
    public float runSpeed;
    public float jumpCheckDistance;
    public float jumpAmount;

    private Rigidbody2D rigidbody;
    private float runDirection;
    private bool pressingJump;
    private int layerMask;

    private void Start()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
        layerMask = LayerMask.GetMask("Environment");
    }

    private void Update()
    {
        runDirection = Input.GetAxisRaw("Horizontal");
        pressingJump = Input.GetButton("Jump");
    }

    private void FixedUpdate()
    {
        Run();
        Jump();
    }

    private void Jump()
    {
        if (pressingJump)
        {
            if (Physics2D.Raycast(transform.position, Vector2.down, jumpCheckDistance, layerMask))
            {
                rigidbody.velocity += new Vector2(0f, jumpAmount);
            }
        }
    }

    private void Run()
    {
        var currentVelocity = rigidbody.velocity;

        currentVelocity.x = runDirection * runSpeed;
        rigidbody.velocity = currentVelocity;
    }
}
