using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<Camera>() != null)
            GetComponent<Camera>().enabled = false;
        if (GetComponent<Renderer>() != null)
            GetComponent<Renderer>().enabled = false;
        if (GetComponent<AudioListener>() != null)
            GetComponent<AudioListener>().enabled = false;
    }
}
