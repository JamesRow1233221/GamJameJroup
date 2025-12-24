using UnityEngine;
using UnityEngine.Rendering.Universal;
using System.Collections;

public class BellGlow : MonoBehaviour
{
    public float boostedIntensity = 40f;
    public float boostTime = 0.15f;
    public GlobalLightController globalLightController;
    public float lightBoostAmount = 0.3f;

    Light2D light2D;
    float normalIntensity;


    void Awake()
    {
        light2D = GetComponentInChildren<Light2D>();
        if (light2D == null )
        {
            Debug.LogError("Bellglow: Light2D is null");
            return;
        }
        normalIntensity = light2D.intensity;

    }

    public void Boost()
    {
        StartCoroutine(BoostRoutine());
    }
    IEnumerator BoostRoutine()
    {
        if (light2D == null) yield break;
        light2D.intensity = boostedIntensity;

        yield return new WaitForSeconds(boostTime);
        if (light2D == null) yield break;
        light2D.intensity = normalIntensity;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Boost(); // bell glow effect
            globalLightController.IncreaseLight(lightBoostAmount);
        }
    }

}
