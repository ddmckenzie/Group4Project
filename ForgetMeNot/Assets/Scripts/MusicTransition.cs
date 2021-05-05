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
    public AudioClip clip3;
    public Animator fader;
    public float transitionTime = 1f;
    Scene scene;

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
        scene = SceneManager.GetActiveScene();

        if (scene.name == "Bedroom" || scene.name == "Combination")
        {
            if (audioSource.clip != clip1)
            {
                StartCoroutine(changeClip(clip1));
            }
        }
        else if (scene.name == "GameOVMenu")
        {
            audioSource.Stop();
        }
        else if (scene.buildIndex >= 14)
        {
            audioSource.Stop();
        }
        else
        {
            if (audioSource.clip != clip2)
            {
                StartCoroutine(changeClip(clip2));
            }
            else if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

    IEnumerator changeClip(AudioClip clip)
    { 
        fader.SetTrigger("fadeout");
        yield return new WaitForSeconds(transitionTime);
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.Play();
        yield return new WaitForSeconds(transitionTime);
        fader.SetTrigger("fadein");
    }
}

//Based on tutorial by Blackthornprod