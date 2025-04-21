using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;
    public Animator animator;
    private float h, v;
    private bool isRunning;
    private PlayerShoot playerShoot;

    void Awake()
    {
        playerShoot = GetComponent<PlayerShoot>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            playerShoot.HandleCatShooting();
        }

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        isRunning = Mathf.Abs(h) > 0 || Mathf.Abs(v) > 0; // h is AD and v is WS. ZO
        animator.SetBool("isRunning", isRunning);
    }
    void FixedUpdate()
    {
        HandleMovement(h, v);
    }
    private void HandleMovement (float h, float v)
    {
        if (isRunning)
        {
            // Calculate movement vector. ZO
            Vector3 tempVect = new Vector3(h, v, 0);
            tempVect = tempVect.normalized * speed * Time.fixedDeltaTime;

            // Move the player. ZO
            rb.MovePosition(rb.transform.position + tempVect);

            if (h != 0)
            {
                Vector3 scale = transform.localScale;
                scale.x = Mathf.Sign(h) * Mathf.Abs(scale.x); // Ensure correct direction
                transform.localScale = scale;
            }
        }
    }
}
