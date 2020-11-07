using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Disposepls_dialoguetester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            DialogueRunner.StartDialogue("Start");
    }
}
