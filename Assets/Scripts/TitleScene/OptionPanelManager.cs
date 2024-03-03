using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPanelManager : MonoBehaviour
{
    [SerializeField] private Button closeOptionButton;
    [SerializeField] private Button penLightButton;
    [SerializeField] private Button normalLightButton;
    [SerializeField] private Button strongLightButton;

    // Start is called before the first frame update
    void Start()
    {      
        closeOptionButton.onClick.AddListener(CloseOptionPanel);
        penLightButton.onClick.AddListener(SetPenLight);
        normalLightButton.onClick.AddListener(SetNormalLight);
        strongLightButton.onClick.AddListener(SetStrongLight);
    }

    private void CloseOptionPanel()
    {
        this.gameObject.SetActive(false);
    }

    private void SetPenLight()
    {
        GradeCalculater.lightSpotAngle = 20.0f;        
        Debug.Log(GradeCalculater.lightSpotAngle);
    }

    private void SetNormalLight()
    {
        GradeCalculater.lightSpotAngle = 40.0f;
        Debug.Log(GradeCalculater.lightSpotAngle);
    }

    private void SetStrongLight()
    {
        GradeCalculater.lightSpotAngle = 60.0f;
        Debug.Log(GradeCalculater.lightSpotAngle);
    }

}
