using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class FlashLightController : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    private Light lightComponent;

    private void Start() 
    {
        lightComponent = this.GetComponent<Light>();
        SetLightBrightness(30f);
    }

    public void SetLightBrightness(float spotAngle)
    {
        lightComponent.spotAngle = spotAngle;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.rotation = cameraTransform.rotation;
    }
}
