using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    [Header("Movimento")]
    public float speed = 5f;

    private Animator anim;
    private SpriteRenderer sr;

    void Awake()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // =========================
        // MOVIMENTO
        // =========================
        float h = Input.GetAxisRaw("Horizontal");

        transform.Translate(
            new Vector3(h * speed * Time.deltaTime, 0f, 0f)
        );

        // =========================
        // FLIP (SEM MEXER NA ESCALA)
        // =========================
        if (h > 0)
            sr.flipX = false;
        else if (h < 0)
            sr.flipX = true;

        // =========================
        // ANIMAÇÃO DE ANDAR
        // =========================
        anim.SetBool("isRunning", h != 0);

        // =========================
        // ATAQUE
        // =========================
        if (Input.GetKeyDown(KeyCode.X))
        {
            anim.ResetTrigger("Attack"); // segurança
            anim.SetTrigger("Attack");
        }
    }
}
