using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPassword : MonoBehaviour
{
    public InputField password;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        Show();
        text.SetActive(false);
        password.ActivateInputField();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (password.text == "0735")
            {
                text.SetActive(true);
                password.DeactivateInputField();
            }
        }
    }

    void Show()
    {
        password.image.enabled = true;
    }

    void Hide()
    {
        password.image.enabled = false;
    }
}
