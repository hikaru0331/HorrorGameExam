using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearTimeCounter : MonoBehaviour
{
    private float time;
    
    ScoreManager scoreManager;

    private void Start() 
    {
        scoreManager = GameObject.FindWithTag("ScoreManager").GetComponent<ScoreManager>();
        SceneManager.sceneUnloaded += SetClearTime;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    private void SetClearTime(Scene scene)
    {
        scoreManager.UpdateClearTime(time);
    }
}
