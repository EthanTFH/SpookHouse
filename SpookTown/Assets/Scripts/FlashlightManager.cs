using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightManager : MonoBehaviour
{

    private Light l;

    // Start is called before the first frame update
    void Start()
    {
        l = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (l.enabled)
            {
                l.enabled = false;
            }
            else
            {
                l.enabled = true;
            }
        }
    }
}
