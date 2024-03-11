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

    ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        penLightButton.onClick.AddListener(SetPenLight);
        normalLightButton.onClick.AddListener(SetNormalLight);
        strongLightButton.onClick.AddListener(SetStrongLight);
        backButton.onClick.AddListener(CloseSelectLightPanel);

        scoreManager = GameObject.FindWithTag("ScoreManager").GetComponent<ScoreManager>();
    }

    private void SetPenLight()
    {
        scoreManager.UpdateLightStrength(20.0f);
        SceneManager.LoadScene("Main");
    }

    private void SetNormalLight()
    {
        scoreManager.UpdateLightStrength(40.0f);
        SceneManager.LoadScene("Main");
    }

    private void SetStrongLight()
    {
        scoreManager.UpdateLightStrength(60.0f);
        SceneManager.LoadScene("Main");
    }

    private void CloseSelectLightPanel()
    {
        this.gameObject.SetActive(false);
    }
}
