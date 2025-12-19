using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI TextStart;
    public TextMeshProUGUI TextSettings;
    public TextMeshProUGUI TextExit;

    public GameObject MainMenu;
    public GameObject MenuStart;
    public GameObject MenuSettings;
    public GameObject MenuExit;
    public GameObject MainSettings;

    void Start()
    {
        MainMenu.SetActive(true);
        MainSettings.SetActive(false);
    }

    public void StartSettings()
    {
        MainMenu.SetActive(false);
        MainSettings.SetActive(true);
    }

    public void SettingsBack()
    {
        MainMenu.SetActive(true);
        MainSettings.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
