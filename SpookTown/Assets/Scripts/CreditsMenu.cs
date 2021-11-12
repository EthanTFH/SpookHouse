using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsMenu : MonoBehaviour
{
    public GameObject MainMenuButton;
    public GameObject QuitButton;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton.GetComponent<Button>().onClick.AddListener(OpenMainMenu);
        QuitButton.GetComponent<Button>().onClick.AddListener(QuitGame);
    }

    void OpenMainMenu()
    {
        Debug.Log("Loading Main Menu");
        SceneManager.LoadScene("MainMenu");
    }

    void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
