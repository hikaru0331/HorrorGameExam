using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeCalculater
{
    public static float clearTime;
    public static float lightSpotAngle = 40.0f;

    public int GradeCalculate() 
    {
        float calcResult = clearTime / 2;

        int grade = GradeEvaluate(calcResult);
        return grade;
    }

    private int GradeEvaluate(float calcResult)
    {
        int grade = 2;

        if(calcResult > 0)
        {
            grade = 1;
        }     

        return grade;
    }
}
