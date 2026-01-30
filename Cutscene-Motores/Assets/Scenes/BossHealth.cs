using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxLife = 100;
    int currentLife;

    void Start()
    {
        currentLife = maxLife;
    }

    public void TakeDamage(int damage)
    {
        currentLife -= damage;
        Debug.Log("Boss levou dano: " + damage);

        if (currentLife <= 0)
            Die();
    }

    void Die()
    {
        Debug.Log("Boss morreu!");
        Destroy(gameObject);
    }
}
