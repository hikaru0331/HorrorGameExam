using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    private SearchTimes searchTimes;

    // Start is called before the first frame update
    void Start()
    {
        searchTimes = new SearchTimes();
    }

    public void AddSearchTimes(int addValue)
    {
        searchTimes.AddSearchTimes(addValue);
    }

    public void ResetAllValues()
    {
        searchTimes.ResetSearchTimes();
    }
}
