using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    private LightStrength lightStrength;
    private SearchTimes searchTimes;
    private ClearTime clearTime;
    
    // Start is called before the first frame update
    void Start()
    {
        lightStrength = new LightStrength();
        searchTimes = new SearchTimes();        
    }

    //ライトの強さに関するメソッド
    public void UpdateLightStrength(float lightValue)
    {
        lightStrength.UpdateLightStrength(lightValue);
    }
    public float GetLightStrength()
    {
        return lightStrength.GetLightStrength();
    }
    public void ResetLightStrength()
    {
        lightStrength.ResetLightStrength();
    }

    //びっくりサーチの使用回数に関するメソッド
    public void AddSearchTimes(int addSearchValue)
    {
        searchTimes.AddSearchTimes(addSearchValue);
    }
    public float GetSearchTimes()
    {
        return searchTimes.GetSearchTimes();
    }
    public void ResetAllValues()
    {
        searchTimes.ResetSearchTimes();
    }

    //クリアタイムに関するメソッド
    public float GetClearTime() 
    {
        return clearTime.GetClearTime();
    }

  public void UpdateClearTime(float time) 
    {
        clearTime.UpdateClearTime(time);
    }

  public void ResetCleraTime()
    {
        clearTime.ResetCleraTime();
    }
}
