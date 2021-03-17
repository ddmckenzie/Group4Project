using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicTransition : MonoBehaviour
{
    private static MusicTransition instance;
    public AudioSource audioSource;
    public AudioClip clip1;
    public AudioClip clip2;

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

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Hallway")
        {
            if (audioSource.clip!=clip2)
            {
                changeClip(clip2);
            }
        }
        else
        {
            if (audioSource.clip!=clip1) {
                changeClip(clip1);
            }
        }
    }

    void changeClip(AudioClip clip) {
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.Play();
    }
}

//Based on tutorial by Blackthornprod