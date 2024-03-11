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
        clearTime = new ClearTime();
    }

    public void ResetAllValues()
    {
        lightStrength.ResetLightStrength();
        searchTimes.ResetSearchTimes();
        clearTime.ResetCleraTime();
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

    //びっくりサーチの使用回数に関するメソッド
    public void AddSearchTimes(int addSearchValue)
    {
        searchTimes.AddSearchTimes(addSearchValue);
    }
    public int GetSearchTimes()
    {
        return searchTimes.GetSearchTimes();
    }

    //クリアタイムに関するメソッド
    public void UpdateClearTime(float time) 
    {
        clearTime.UpdateClearTime(time);
    }
    public float GetClearTime() 
    {
        return clearTime.GetClearTime();
    }
}
