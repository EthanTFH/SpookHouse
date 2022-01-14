using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject PlayButton;
    public GameObject OptionsButton;
    public GameObject QuitButton;
    public GameObject MainMenuPanel;
    public GameObject MainMenuButton;

    public GameObject OptionMenuPanel;
    public GameObject returnToMenu;

    // Start is called before the first frame update
    void Start()
    {
        PlayButton.GetComponent<Button>().onClick.AddListener(Play);
        OptionsButton.GetComponent<Button>().onClick.AddListener(OpenOptionsMenu);
        QuitButton.GetComponent<Button>().onClick.AddListener(QuitGame);
        returnToMenu.GetComponent<Button>().onClick.AddListener(ReturnToMain);
    }

    // Update is called once per frame
    void Play() 
    {
        Debug.Log("Test");
        SceneManager.LoadScene("Outside");
    }

    void OpenOptionsMenu() 
    {
        Debug.Log("Open Options Panel");
        MainMenuPanel.SetActive(false);
        OptionMenuPanel.SetActive(true);
    }

    void ReturnToMain()
    {
        Debug.Log("Going back to menu");
        MainMenuPanel.SetActive(true);
        OptionMenuPanel.SetActive(false);
    }

    void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();

    }

    void Update()
    {
        
    }
}
