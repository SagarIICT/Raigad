using UnityEngine;

public class MavlaMove1 : MonoBehaviour
{
    public Rigidbody2D Body;
    public float speed = 5f;

    private Vector2 finalSpeed;
    public SpriteRenderer sr;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        //float y = Input.GetAxisRaw("Vertical");

        finalSpeed = new Vector2(x, 0);

        Body.linearVelocity = finalSpeed * speed;

        if (x < 0f)
        {
            sr.flipX = true;
        }
        else if (x > 0f)
        {
            sr.flipX = false;
        }
    }
}