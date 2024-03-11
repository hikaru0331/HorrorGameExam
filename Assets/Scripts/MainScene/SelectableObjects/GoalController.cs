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
    [SerializeField] private GameObject haveKeyText;

    public override void HitNow()
    {
        base.HitNow();

        if(Input.GetMouseButtonDown(0))
        {
            if(KeyContainer.hasKey)
            {
                SceneManager.LoadScene("Result");
                KeyContainer.hasKey = false;
                Cursor.visible = true;
            }
            else
            {
                haveKeyText.SetActive(true);
            }
            
        }
    }

    public override void NotHit()
    {
        base.NotHit();
        haveKeyText.SetActive(false);
    }
}
