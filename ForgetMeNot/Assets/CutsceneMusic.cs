using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneMusic : MonoBehaviour
{
    private static CutsceneMusic instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Scene6") {
            Destroy(gameObject);
        }
    }
}
