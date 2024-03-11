using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTime
{
  private float clearTime;
  private const float MIN_TIME = 0.0f;

  public float GetClearTime() 
  {
    return clearTime;
  }

  public void UpdateClearTime(float time) 
  {
    this.clearTime = time;
  }

  public void ResetCleraTime()
  {
    clearTime = MIN_TIME;
  }
}
