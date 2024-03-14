using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GradeDisplayer : MonoBehaviour
{
    private int grade;
    [SerializeField] private TextMeshProUGUI resultText; 

    ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.FindWithTag("ScoreManager").GetComponent<ScoreManager>();
        GradeCalculater gradeCalculater = new GradeCalculater();

        Debug.Log("ライトの強さ" + scoreManager.GetLightStrength());
        Debug.Log("サーチ回数" + scoreManager.GetSearchTimes());
        Debug.Log("クリア時間" + scoreManager.GetClearTime());
        grade = gradeCalculater.GradeCalculate(scoreManager.GetLightStrength(), scoreManager.GetSearchTimes(), scoreManager.GetClearTime());

        resultText.text = "あなたの検定結果は" + grade.ToString() + "級です";

        scoreManager.ResetAllValues();
    }
}
