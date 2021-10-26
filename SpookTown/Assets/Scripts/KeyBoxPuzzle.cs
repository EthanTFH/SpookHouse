using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoxPuzzle : MonoBehaviour
{

    public GameObject key;
    private NextScene script;

    // Start is called before the first frame update
    void Start()
    {
        script = gameObject.GetComponent<NextScene>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLIDED WITH " + other.name);
        if(other.name == "KEY_COLLIDER")
        {
            Destroy(key);
            script.canProgress = true;
        }
    }
}
