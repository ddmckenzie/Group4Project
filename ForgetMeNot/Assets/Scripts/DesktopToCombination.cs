using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesktopToCombination : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Combination");
    }
}