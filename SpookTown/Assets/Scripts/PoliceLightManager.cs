using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceLightManager : MonoBehaviour
{
    public GameObject l1, l2, l3, l4;

    // Start is called before the first frame update
    void Start()
    {
        l1.SetActive(false);
        l2.SetActive(true);
        l3.SetActive(false);
        l4.SetActive(false);

        StartCoroutine("flash");
    }

    public IEnumerator flash()
    {
        while (true)
        {
            float wait = Random.value;
            if (wait < 0.1f)
                wait = 0.1f;
            if (wait > 0.5f)
                wait = 0.5f;

            l1.SetActive(Random.value > 0.5);
            l2.SetActive(Random.value > 0.5);
            l3.SetActive(Random.value > 0.5);
            l4.SetActive(Random.value > 0.5);
            yield return new WaitForSeconds(wait);

            wait = Random.value;
            if (wait < 0.1f)
                wait = 0.1f;
            if (wait > 0.5f)
                wait = 0.5f;

            l1.SetActive(Random.value > 0.5);
            l2.SetActive(Random.value > 0.5);
            l3.SetActive(Random.value > 0.5);
            l4.SetActive(Random.value > 0.5);
            yield return new WaitForSeconds(wait);
        }
    }
}
