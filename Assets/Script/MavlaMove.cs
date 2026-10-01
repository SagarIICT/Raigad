using UnityEngine;

public class MavlaMove : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed = 5f;
    public SpriteRenderer spriteRenderer;
    public Animator animator;

    private Vector2 finalSpeed;
    public SpriteRenderer sr;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        //float y = Input.GetAxisRaw("Vertical");

        finalSpeed = new Vector2(x, 0);

        body.linearVelocity = finalSpeed * speed;

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("IsWalking", true);
            spriteRenderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("IsWalking", true);
            spriteRenderer.flipX = false;
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }

    }
}