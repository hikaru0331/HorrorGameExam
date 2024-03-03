using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GradeDisplayer : MonoBehaviour
{
    private int grade;
    [SerializeField] private TextMeshProUGUI resultText; 

    // Start is called before the first frame update
    void Start()
    {
        GradeCalculater gradeCalculater = new GradeCalculater();
        grade = gradeCalculater.GradeCalculate();

        resultText.text = "Your grade is " + grade.ToString() + ".";
    }
}
