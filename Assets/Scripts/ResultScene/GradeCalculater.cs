using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeCalculater
{    
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

        if(calcResult < 100)
        {
            grade = 1;
        }
        else if(calcResult < 200)
        {
            grade = 2;
        }
        else if(calcResult < 300)
        {
            grade = 3;
        }

        return grade;
    }
}
