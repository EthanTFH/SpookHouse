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

    public float timeBetweenCharacter = 0.08f;
    public Text textLabel;
    public Text promptLabel;

    public int nextDiag = 0;
    public string[] dialog = {"You hadn't heard from your grandma in some time...", "You decided this would be a good time for a visit\nto see how she is doing.",
    "'Unusual weather we are having, you should have stayed home.'\nYou already knew what she was going to say.",
    "Little did you know what was behind that door."};

    private Scene scene;

    public bool canProgress = false;

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

    public IEnumerator addDialog(int num)
    {
        if (num == nextDiag)
        {
            string diag = dialog[num];
            textLabel.text = "";
            nextDiag++;
			for (int i = 0; i < diag.ToCharArray().Length; i++)
            {
                textLabel.text += diag.ToCharArray()[i];
                yield return new WaitForSeconds(timeBetweenCharacter);
            }
        }
    }

    public IEnumerator flashlightPrompt()
    {
        promptLabel.text = "Press [f] to toggle your flashlight!";
        yield return new WaitForSeconds(5);
        promptLabel.text = "";
    }

    public IEnumerator promptNoProgress()
    {
        string diag = "You cannot progress yet.";
        for (int i = 0; i < diag.ToCharArray().Length; i++)
        {
            textLabel.text += diag.ToCharArray()[i];
            yield return new WaitForSeconds(timeBetweenCharacter);
        }
        yield return new WaitForSeconds(5);
        textLabel.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered");
        if (other.gameObject.name == "NextScene" && (canProgress || isPathwayScene))
        {
            StartCoroutine("startFade");
        }
        else if (other.gameObject.name == "NextScene" && !(canProgress || isPathwayScene))
        {
            StartCoroutine("promptNoProgress");
        }
        else
        {
            string[] parts = other.gameObject.name.Split('r');
            if(parts[0] == "DialogCollide")
            {
                int num = int.Parse(parts[1]);
                StartCoroutine(addDialog(num));
            }
            if(other.gameObject.name == "FlashlightTrigger")
            {
                StartCoroutine("flashlightPrompt");
            }
        }
    }
}
