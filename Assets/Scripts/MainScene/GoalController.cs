using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Select中に左クリックするとチャットが出るスクリプト
/// </summary>
public class GoalController : SelectRayOutline
{    
    public override void HitNow()
    {
        base.HitNow();

        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Result");
            Cursor.visible = true;
        }
    }
}
