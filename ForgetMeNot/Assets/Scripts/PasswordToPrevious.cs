using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasswordToPrevious : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void prevScene()
    {
        SceneManager.LoadScene("Bedroom");
    }
}