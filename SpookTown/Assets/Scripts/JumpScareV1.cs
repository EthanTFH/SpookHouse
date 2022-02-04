using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpScareV1 : MonoBehaviour
{
    public GameObject jumpScare;
    public float TimeOnScreen;


    

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered!!!!!");
        jumpScare.SetActive(true);
        StartCoroutine(WaitBeforeShow());
    }

    private IEnumerator WaitBeforeShow()
    {
        yield return new WaitForSeconds(TimeOnScreen);
        Debug.Log("Waited for 2 seconds!");
        jumpScare.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
