using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasswordToPrevious : MonoBehaviour
{
    
    public void prevScene()
    {
        SceneManager.LoadScene("Desktop");
    }
}