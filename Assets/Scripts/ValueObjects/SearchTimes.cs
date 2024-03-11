using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class SearchTimes
{
  private int searchTimes;
  private const int MIN_TIMES = 0;
  private const int MAX_TIMES = 10;
    
  public int GetSearchTimes() 
  {
    return searchTimes;
  }

  public void AddSearchTimes(int addValue) 
  {
    this.searchTimes = Mathf.Clamp(searchTimes + addValue, MIN_TIMES, MAX_TIMES);
  }

  public void ResetSearchTimes()
  {
    searchTimes = MIN_TIMES;
  }
}