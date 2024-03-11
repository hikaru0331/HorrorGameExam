using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightStrength
{
  private float lightStrength;
  private const int MIN_STRENGTH = 20;
  private const int DEFAULT_STRENGTH = 40;
  private const int MAX_STRENGTH = 60;
    
  public float GetLightStrength() 
  {
    return lightStrength;
  }

  public void UpdateLightStrength(float value) 
  {
    this.lightStrength = Mathf.Clamp(value, MIN_STRENGTH, MAX_STRENGTH);
  }

  public void ResetLightStrength()
  {
    lightStrength = DEFAULT_STRENGTH;
  }
}
