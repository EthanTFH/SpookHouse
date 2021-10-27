using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightManager : MonoBehaviour
{

    public GameObject l;

    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            sound.Play();
            if (l.activeInHierarchy)
            {
                l.SetActive(false);
            }
            else
            {
                l.SetActive(true);
            }
        }
    }
}
