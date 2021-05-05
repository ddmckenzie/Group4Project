using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{

    public void QuitGame ()
    {
        SaveManager.instance.DeleteSaveData();
        Application.Quit();
    }
}