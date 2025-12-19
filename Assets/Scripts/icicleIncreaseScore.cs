using UnityEngine;

public class icicleIncreaseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.UpdateScore();
        }
    }
}
