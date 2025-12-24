using UnityEngine;

public class UIfixedRatioScreen : MonoBehaviour
{
    private const float targetAspect = 18f / 32f;
    private RectTransform rect;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
        Apply();
    }

    void OnRectTransformDimensionsChange()
    {
        Apply();
    }

    void Apply()
    {
        float screenAspect = (float)Screen.width / Screen.height;

        if (screenAspect > targetAspect)
        {
            // Too wide → pillarbox
            float width = Screen.height * targetAspect;
            rect.sizeDelta = new Vector2(width, Screen.height);
        }
        else
        {
            // Too tall → letterbox
            float height = Screen.width / targetAspect;
            rect.sizeDelta = new Vector2(Screen.width, height);
        }

        rect.anchoredPosition = Vector2.zero;
    }
}
