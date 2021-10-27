using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsManager : MonoBehaviour
{

    public Text finalThanks;

    public Text[] textObjects;
    public float displayTime = 5.0f;
    public float scrollTime = 5.0f;
    public float scrollSpeed = 0.2f;

    private bool shownFinalEnd = false;

    void Start()
    {
        
    }

    void Update()
    {

        displayTime -= Time.deltaTime;

        if (displayTime < 0)
        {
            scrollTime -= Time.deltaTime;
        }

        if(scrollTime < -42 && !shownFinalEnd)
        {
            StartCoroutine("creditsEnd");
            shownFinalEnd = true;
        }

        if (scrollTime < 0)
        {
            foreach (Text text in textObjects)
            {
                text.transform.Translate(Vector3.up * scrollSpeed);
            }
        }
    }

    public IEnumerator creditsEnd()
    {
        while (finalThanks.color.a < 1)
        {
            Color objectColor = finalThanks.color;
            float fadeAmount = objectColor.a + (Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            finalThanks.color = objectColor;
            yield return null;
        }
        yield return new WaitForSeconds(10);
        Debug.Log("Application Quit, does not actually work in the editor.");
        Application.Quit();
    }

}
