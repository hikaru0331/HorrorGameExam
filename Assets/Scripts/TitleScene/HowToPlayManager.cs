using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlayManager : MonoBehaviour
{
    [SerializeField] private Button nextButton;
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject[] howToPlayPanels;
    [SerializeField] private GameObject selectLightPanel;

    [SerializeField] private TextMeshProUGUI pageText;

    private int activeHTPNumber = 0;

    private int minHTP = 0;
    private int maxHTP;    

    // Start is called before the first frame update
    void Start()
    {
        nextButton.onClick.AddListener(OpenNextHTP);
        backButton.onClick.AddListener(OpenPostHTP);

        pageText.text = (activeHTPNumber + 1) + " / " + howToPlayPanels.Length;

        maxHTP = howToPlayPanels.Length - 1;
    }

    private void OpenNextHTP()
    {
        if (activeHTPNumber < maxHTP)
        {
            activeHTPNumber++;
            howToPlayPanels[activeHTPNumber].SetActive(true);

            pageText.text = (activeHTPNumber + 1) + " / " + howToPlayPanels.Length;
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

            pageText.text = (activeHTPNumber + 1) + " / " + howToPlayPanels.Length;
        }
        else
        {
            this.gameObject.SetActive(false);
        }   
    }
}
