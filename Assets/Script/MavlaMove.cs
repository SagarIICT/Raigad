using UnityEngine;
using UnityEngine.SceneManagement;

public class MavlaMove : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed = 5f;

    public SpriteRenderer spriteRenderer;
    public Animator animator;
    public GameObject camera;

    public GameObject pointA;
    public GameObject pointB;
    public GameObject pointC;
    public GameObject pointD;

    private Vector2 finalSpeed;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "S5 Raj Sadar")
        {
            Camera.main.orthographicSize = 28.5f;
        }
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "S5 Raj Sadar")
        {
            float playerX = body.transform.position.x;

            float A = pointA.transform.position.x;
            float B = pointB.transform.position.x;
            float C = pointC.transform.position.x;
            float D = pointD.transform.position.x;

            // A → B : 28.5 → 45
            if (playerX >= A && playerX <= B)
            {
                float t = Mathf.InverseLerp(A, B, playerX);

                Camera.main.orthographicSize =
                    Mathf.Lerp(28.5f, 45f, t);
            }

            // B → C : stay 45
            else if (playerX > B && playerX < C)
            {
                Camera.main.orthographicSize = 45f;
            }

            // C → D : 45 → 28.5
            else if (playerX >= C && playerX <= D)
            {
                float t = Mathf.InverseLerp(C, D, playerX);

                Camera.main.orthographicSize =
                    Mathf.Lerp(45f, 24.5f, t);
            }

            // After D : stay 28.5
            else if (playerX > D)
            {
                Camera.main.orthographicSize = 24.5f;
            }
        }

        // PLAYER MOVEMENT

        float x = Input.GetAxisRaw("Horizontal");

        finalSpeed = new Vector2(x, 0);

        body.linearVelocity = finalSpeed * speed;

        // WALKING ANIMATION

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