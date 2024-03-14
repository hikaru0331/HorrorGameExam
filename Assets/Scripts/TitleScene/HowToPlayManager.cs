using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlayManager : MonoBehaviour
{
    [SerializeField] private Button nextButton;
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject[] howToPlayPanels;
    [SerializeField] private GameObject selectLightPanel;

    private int activeHTPNumber = 0;

    private int minHTP = 0;
    private int maxHTP;    

    // Start is called before the first frame update
    void Start()
    {
        nextButton.onClick.AddListener(OpenNextHTP);
        backButton.onClick.AddListener(OpenPostHTP);

        maxHTP = howToPlayPanels.Length - 1;
    }

    private void OpenNextHTP()
    {
        if (activeHTPNumber < maxHTP)
        {
            activeHTPNumber++;
            howToPlayPanels[activeHTPNumber].SetActive(true);
        }
        else
        {
            selectLightPanel.SetActive(true);
        }
    }

    private void OpenPostHTP()
    {
        if (activeHTPNumber > minHTP)
        {
            howToPlayPanels[activeHTPNumber].SetActive(false);
            activeHTPNumber--;
        }
        else
        {
            this.gameObject.SetActive(false);
        }   
    }
}
