using UnityEngine;

public class BossStingerTrigger : MonoBehaviour
{
    private bool hasPlayed = false;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (hasPlayed) return;

        if (other.CompareTag("Player"))
        {
            audioSource.Play();
            hasPlayed = true;
        }
    }
}

