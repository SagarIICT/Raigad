using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MavlaMove : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed = 5f;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    public GameObject camera;

    private float distance;
    private float currentDistance;

    public GameObject pointA;
    public GameObject pointB;

    private Vector2 finalSpeed;
    public SpriteRenderer sr;

     void Start()
    {
        if (SceneManager.GetActiveScene().name == "S5 Raj Sadar")
        {
           
        distance = Vector3.Distance(pointA.transform.position, pointB.transform.position);
        }

    }
    void Update()
    {

        if (SceneManager.GetActiveScene().name == "S5 Raj Sadar")
        {
            currentDistance = Vector3.Distance(body.transform.position, pointB.transform.position);
            //Debug.Log("Distance:" + currentDistance);
            float distanceRatio = currentDistance / distance;
            //Debug.Log("DistanceRatio " + DistanceRatio);
            float cameraSize = Mathf.Lerp(45f, 28.5f, distanceRatio);
            Debug.Log("Zoom Level " + Mathf.Lerp(45f, 28.5f, distanceRatio));


            if (body.gameObject.transform.position.x < pointB.transform.position.x)
            {
                //Camera.main.orthographicSize = 45;
                Camera.main.orthographicSize = cameraSize;
            }
        }
        

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