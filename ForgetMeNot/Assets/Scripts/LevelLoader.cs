using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    void Update()
    {

    }
    public void LoadNextLevel()
    {
        SaveManager.instance.Save();
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadRoom(int room) //Loads room by its scene index
    {
        SaveManager.instance.Save();
        StartCoroutine(LoadLevel(room));
    }

    public void LoadRoom(string room) //Loads room by its name
    {
        SaveManager.instance.Save();
        StartCoroutine(LoadLevel(room));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }

    IEnumerator LoadLevel(string name)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(name);
    }
}
