using UnityEngine;

public class BellRing : MonoBehaviour
{
    [SerializeField] private BellGlow glow;


    private void Awake()
    {
        glow = GetComponentInParent<BellGlow>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (glow != null)
        glow.Boost();
    }
}
