using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GlobalLightController : MonoBehaviour
{
    public Light2D globalLight;

    public float darknessSpeed = 20f;
    public float minimumLight = 0.001f;
    public float maxLight = 1f;

    private void Update()
    {
        if (globalLight.intensity > minimumLight)
        {
            globalLight.intensity -= darknessSpeed * Time.deltaTime;
            globalLight.intensity = Mathf.Max(globalLight.intensity, minimumLight);
        }
    }

    public void IncreaseLight(float amount)
    {
        globalLight.intensity += amount;
        globalLight.intensity = Mathf.Clamp(globalLight.intensity, minimumLight, maxLight);
    }

}
