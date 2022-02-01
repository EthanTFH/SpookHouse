using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    public static bool IsGamePaused = false;
    public GameObject PausePanelPanel;
    public GameObject OptionPanel;
    public GameObject ButtonPanel;
    public GameObject ResumeButton;
    public GameObject OptionsButton;
    public GameObject MainMenuButton;
    public GameObject OptionsBack;

    // Start is called before the first frame update
    void Start()
    {
        //Pausing game:
        IsGamePaused = true;
        Time.timeScale = 0f;

        //Cursor
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        Debug.Log("Pausegamev1");
    }

    public void ResumeGame() 
    {
        Debug.Log("Game Resumed");
        //Set time back to normal
        Time.timeScale = 1f;
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        IsGamePaused = false;
        PausePanelPanel.SetActive(false);
    }

    public void OpenOptionsMenu() 
    {
        Debug.Log("OptionsMenuOpened");
        ButtonPanel.SetActive(false);
        OptionPanel.SetActive(true);
    }

    public void CloseOptionsMenu()
    {
        Debug.Log("Options Panel Closed");
        ButtonPanel.SetActive(true);
        OptionPanel.SetActive(false);
    }

    public void OpenMainMenu()
    {
        Debug.Log("Going to Main Menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
