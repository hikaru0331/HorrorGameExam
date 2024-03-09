using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPanelManager : MonoBehaviour
{
    [SerializeField] private Button closeOptionButton;

    // Start is called before the first frame update
    void Start()
    {      
        closeOptionButton.onClick.AddListener(CloseOptionPanel);
    }

    private void CloseOptionPanel()
    {
        this.gameObject.SetActive(false);
    }
}
