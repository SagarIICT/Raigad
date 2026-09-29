using UnityEngine;

public class MavlaMove : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed = 5f;

    private Vector2 finalSpeed;
    public SpriteRenderer sr;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        //float y = Input.GetAxisRaw("Vertical");

        finalSpeed = new Vector2(x, 0);

        body.linearVelocity = finalSpeed * speed;
    }
}