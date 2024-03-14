using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTitleScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (GradeDisplayer.canLoadTitleScene && Input.GetMouseButtonDown(0))
        {
            GradeDisplayer.canLoadTitleScene = false;
            SceneManager.LoadScene("Title");
        }
    }
}
