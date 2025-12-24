using UnityEngine;

public class BellRing : MonoBehaviour
{
    public string triggerTag = "Player";

    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(triggerTag))
        {
            audioSource.Play();
        }
    }
}
