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
    public AudioClip clip4;
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

        //Room scenes
        if (scene.buildIndex >= 1 && scene.buildIndex <= 5)
        {
            if (SaveManager.instance.hasLoaded)
            {
                if (SaveManager.instance.activeSave.unlockedDoors.Contains(0) && SaveManager.instance.activeSave.gasOn == false)
                {
                    playClip(clip2);
                }
                else if (SaveManager.instance.activeSave.unlockedDoors.Contains(0) && SaveManager.instance.activeSave.gasOn == true)
                {
                    playClip(clip3);
                }
                else
                {
                    playClip(clip1);
                }
            }
            else playClip(clip1);
        }
        //Game Over menu
        else if (scene.name == "GameOVMenu")
        {
            audioSource.Stop();
        }
        //Ending cutscenes
        else if (scene.buildIndex >=14)
        {
            playClip(clip4);
        }

        //if (scene.name == "Bedroom" || scene.name == "Combination")
        //{
        //    if (audioSource.clip != clip1)
        //    {
        //        StartCoroutine(changeClip(clip1));
        //    }
        //}
        //else if (scene.name == "GameOVMenu")
        //{
        //    audioSource.Stop();
        //}
        //else if (scene.buildIndex >= 14)
        //{
        //    if (audioSource.clip != clip4)
        //    {
        //        StartCoroutine(changeClip(clip4));
        //    }
        //}
        //else
        //{
        //    if (audioSource.clip != clip2)
        //    {
        //        StartCoroutine(changeClip(clip2));
        //    }
        //    else if (!audioSource.isPlaying)
        //    {
        //        audioSource.Play();
        //    }
        //}
    }

    private void playClip(AudioClip clip)
    {
        if (audioSource.clip != clip)
        {
            StartCoroutine(changeClip(clip));
        }
        else if (!audioSource.isPlaying)
        {
            audioSource.Play();
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