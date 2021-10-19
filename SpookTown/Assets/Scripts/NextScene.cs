using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;
    public bool isPathwayScene = false;
    public GameObject panel;

    private Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        if (isPathwayScene)
        {
            panel.GetComponent<Image>().color = new Color(panel.GetComponent<Image>().color.r, panel.GetComponent<Image>().color.g, panel.GetComponent<Image>().color.b, 0);
        }

        scene = SceneManager.GetActiveScene();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator FadeBlack()
    {
        Debug.Log("Fading to death");
        Color objectColor = panel.GetComponent<Image>().color;
        float fadeAmount;

        while (panel.GetComponent<Image>().color.a < 1)
        {
            controller.m_WalkSpeed = 0f;
            fadeAmount = objectColor.a + (Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            panel.GetComponent<Image>().color = objectColor;
            yield return null;
        }
    }

    public IEnumerator startFade()
    {
        yield return FadeBlack();

        int currentScene = scene.buildIndex;
        SceneManager.LoadScene(currentScene + 1, LoadSceneMode.Single);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered");
        if (other.gameObject.name == "Player")
        {
            StartCoroutine("startFade");
        }
    }
}