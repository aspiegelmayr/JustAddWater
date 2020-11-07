using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnSceneChange : MonoBehaviour
{
    static DontDestroyOnSceneChange _instance;

    // Start is called before the first frame update
    void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        } else
        {
            _instance = this;
            DontDestroyOnLoad(_instance.gameObject);
        }
    }
}
