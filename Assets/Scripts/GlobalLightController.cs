using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GlobalLightController : MonoBehaviour
{
    public Light2D globalLight;

    public float darknessSpeed = 5f;
    public float minimumLight = 0.0005f;

    private void Update()
    {
        if (globalLight.intensity > minimumLight) 
            {
                globalLight.intensity -= darknessSpeed * (Time.deltaTime * 5);
            }
    }
}
