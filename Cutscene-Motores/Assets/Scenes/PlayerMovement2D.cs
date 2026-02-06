using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    [Header("Movimento")]
    public float speed = 5f;
    public float jumpForce = 8f;

    [Header("Chão")]
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundRadius = 0.2f;

    private Animator anim;
    private SpriteRenderer sr;
    private Rigidbody2D rb;

    private bool isGrounded;

    void Awake()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // =========================
        // CHECAR CHÃO
        // =========================
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            groundRadius,
            groundLayer
        );

        // =========================
        // MOVIMENTO
        // =========================
        float h = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(h * speed, rb.linearVelocity.y);

        // =========================
        // FLIP
        // =========================
        if (h > 0)
            sr.flipX = false;
        else if (h < 0)
            sr.flipX = true;

        // =========================
        // ANIMAÇÕES
        // =========================
        anim.SetBool("IsRunning", h != 0);
        anim.SetBool("IsGrounded", isGrounded);

        // =========================
        // PULO
        // =========================
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            anim.SetTrigger("Jump");
        }

        // =========================
        // ATAQUE
        // =========================
        if (Input.GetKeyDown(KeyCode.X))
        {
            anim.SetTrigger("Attack");
        }
    }

    void OnDrawGizmos()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundRadius);
        }
    }
}

