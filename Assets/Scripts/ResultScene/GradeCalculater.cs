using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeCalculater
{    
    private int minute = 60;

    public int GradeCalculate(float lightStrength, int searchTimes, float clearTime) 
    {
        float calcResult = lightStrength + ((float)searchTimes * 10) + clearTime;

        Debug.Log("計算結果" + calcResult);
        int grade = GradeEvaluate(calcResult);
        return grade;
    }

    private int GradeEvaluate(float calcResult)
    {
        int grade = 4;

        if(calcResult < minute * 3)
        {
            grade = 1;
        }
        else if(calcResult < minute * 5)
        {
            grade = 2;
        }
        else if(calcResult < minute * 7)
        {
            grade = 3;
        }

        return grade;
    }
}
