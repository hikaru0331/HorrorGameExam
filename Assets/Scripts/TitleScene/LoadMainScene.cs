using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMainScene : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button optionButton;
    [SerializeField] private Button exitButton;

    [SerializeField] private GameObject optionPanel;
    

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(LoadMain);
        optionButton.onClick.AddListener(OpenOptionPanel);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }

    private void OpenOptionPanel()
    {
        optionPanel.SetActive(true);
    }
    
    private void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
