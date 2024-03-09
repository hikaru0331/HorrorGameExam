using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectLightPanelManager : MonoBehaviour
{
    [SerializeField] private Button penLightButton;
    [SerializeField] private Button normalLightButton;
    [SerializeField] private Button strongLightButton;
    [SerializeField] private Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        penLightButton.onClick.AddListener(SetPenLight);
        normalLightButton.onClick.AddListener(SetNormalLight);
        strongLightButton.onClick.AddListener(SetStrongLight);
        backButton.onClick.AddListener(CloseSelectLightPanel);
    }

    private void SetPenLight()
    {
        GradeCalculater.lightSpotAngle = 20.0f;        
        Debug.Log(GradeCalculater.lightSpotAngle);
        SceneManager.LoadScene("Main");
    }

    private void SetNormalLight()
    {
        GradeCalculater.lightSpotAngle = 40.0f;
        Debug.Log(GradeCalculater.lightSpotAngle);
        SceneManager.LoadScene("Main");
    }

    private void SetStrongLight()
    {
        GradeCalculater.lightSpotAngle = 60.0f;
        Debug.Log(GradeCalculater.lightSpotAngle);
        SceneManager.LoadScene("Main");
    }

    private void CloseSelectLightPanel()
    {
        this.gameObject.SetActive(false);
    }
}
