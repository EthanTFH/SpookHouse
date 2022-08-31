using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpScareV1 : MonoBehaviour
{
    public GameObject jumpScare;
    public float TimeOnScreen;
    public bool EnableJumpscare = true;
    public bool Repeatable = false;
    bool hasTriggeredBefore = false;


    

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (EnableJumpscare == true && hasTriggeredBefore == false)
        {
            Debug.Log("Triggered!!!!!");
            jumpScare.SetActive(true);
            StartCoroutine(WaitBeforeShow());
        }
    }

    private IEnumerator WaitBeforeShow()
    {
        yield return new WaitForSeconds(TimeOnScreen);
        Debug.Log("Waited for 2 seconds!");
        jumpScare.SetActive(false);
        if (Repeatable == false)
        {
            hasTriggeredBefore = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
