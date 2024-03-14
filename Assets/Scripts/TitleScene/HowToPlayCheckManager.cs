using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlayCheckManager : MonoBehaviour
{    
    [SerializeField] private Button yesButton;
    [SerializeField] private Button noButton;
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject howToPlayPanel;
    [SerializeField] private GameObject selectLightPanel;

    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(CloseHowToPlayCheckPanel);
        yesButton.onClick.AddListener(OpenHowToPlayPanel);
        noButton.onClick.AddListener(OpenSelectLightPanel);
    }

    private void OpenHowToPlayPanel()
    {
        howToPlayPanel.SetActive(true);
    }

    private void OpenSelectLightPanel()
    {
        selectLightPanel.SetActive(true);
    }

    private void CloseHowToPlayCheckPanel()
    {
        this.gameObject.SetActive(false);
    }
}
