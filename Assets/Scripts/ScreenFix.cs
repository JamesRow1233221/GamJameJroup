using UnityEngine;

public class ScreenFix : MonoBehaviour
{
    private readonly float targetAspect = 9f / 16f;

    void Start()
    {
        ApplyAspectRatio();
    }

    void ApplyAspectRatio()
    {
        float windowAspect = (float)Screen.width / Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        Camera cam = Camera.main;
        if (cam == null) return;

        Rect rect = cam.rect;

        if (scaleHeight < 1.0f)
        {
            // Add letterbox (top & bottom)
            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1.0f - scaleHeight) / 2.0f;
        }
        else
        {
            // Add pillarbox (left & right)
            float scaleWidth = 1.0f / scaleHeight;
            rect.width = scaleWidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scaleWidth) / 2.0f;
            rect.y = 0;
        }

        cam.rect = rect;
    }
}
