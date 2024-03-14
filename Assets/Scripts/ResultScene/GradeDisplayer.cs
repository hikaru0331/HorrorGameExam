using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GradeDisplayer : MonoBehaviour
{
    ScoreManager scoreManager;
    private int grade;

    [SerializeField] private GameObject gradeMetaphorTextObj;
    [SerializeField] private TextMeshProUGUI gradeMetaphorText;

    [SerializeField] private GameObject gradeTextObj;
    [SerializeField] private TextMeshProUGUI gradeText; 

    [SerializeField] private GameObject lightStrengthTextObj;
    [SerializeField] private TextMeshProUGUI lightStrengthText;

    [SerializeField] private GameObject searchTimesTextObj;
    [SerializeField] private TextMeshProUGUI searchTimesText;

    [SerializeField] private GameObject clearTimeTextObj;
    [SerializeField] private TextMeshProUGUI clearTimeText;

    private float waitSecond = 0.5f; 

    public static bool canLoadTitleScene = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.FindWithTag("ScoreManager").GetComponent<ScoreManager>();
        GradeCalculater gradeCalculater = new GradeCalculater();

        grade = gradeCalculater.GradeCalculate(scoreManager.GetLightStrength(), scoreManager.GetSearchTimes(), scoreManager.GetClearTime());

        gradeText.text = "あなたの検定結果は " + grade.ToString() + " 級です";

        switch(grade)
        {
            case 1:
                gradeMetaphorText.text = "ホラゲー達人レベル";
                break;
            case 2:
                gradeMetaphorText.text = "ホラゲーカジュアル勢レベル";
                break;
            case 3:
                gradeMetaphorText.text = "ホラゲー初心者レベル";
                break;
            case 4:
                gradeMetaphorText.text = "ビビりレベル";
                break;
            default:
                gradeMetaphorText.text = "不明";
                break;
        }

        switch(scoreManager.GetLightStrength())
        {
            case 40.0f:
                lightStrengthText.text = "選んだライト：ペンライト";
                break;
            case 60.0f:
                lightStrengthText.text = "選んだライト：懐中電灯";
                break;
            case 80.0f:
                lightStrengthText.text = "選んだライト：業務用懐中電灯";
                break;
            default:
                lightStrengthText.text = "選んだライト：不明";
                break;
        }

        searchTimesText.text = "サーチ回数：" + scoreManager.GetSearchTimes().ToString() + "回";
        clearTimeText.text = "クリア時間：" + scoreManager.GetClearTime().ToString("f2") + "秒";

        StartCoroutine(DisplayTexts());

        scoreManager.ResetAllValues();
    }

    IEnumerator DisplayTexts()
    {
        lightStrengthTextObj.SetActive(true);
        yield return new WaitForSeconds(waitSecond);

        searchTimesTextObj.SetActive(true);
        yield return new WaitForSeconds(waitSecond);

        clearTimeTextObj.SetActive(true);
        yield return new WaitForSeconds(waitSecond);

        gradeTextObj.SetActive(true);
        gradeMetaphorTextObj.SetActive(true);
        
        canLoadTitleScene = true;
    }
}
