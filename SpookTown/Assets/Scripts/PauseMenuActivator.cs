using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuActivator : MonoBehaviour
{
    public GameObject PausePanel;
    public bool allowPauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && allowPauseMenu == true)
        {
            Debug.Log("Esc pressed");
            PausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
