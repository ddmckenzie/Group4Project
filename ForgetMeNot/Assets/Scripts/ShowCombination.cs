using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCombination : MonoBehaviour
{
    public InputField combination;
    public GameObject drawer;
    // Start is called before the first frame update
    void Start()
    {
        combination.image.enabled = false;
        combination.transform.Find("Placeholder").gameObject.SetActive(false);
        combination.transform.Find("Text").gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        Show();
        combination.ActivateInputField();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (combination.text == "1228")
        {
            drawer.GetComponent<BoxCollider>().enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Hide();
            combination.DeactivateInputField();
        }
    }

    void Show()
    {
        combination.image.enabled = true;
        combination.transform.Find("Placeholder").gameObject.SetActive(true);
        combination.transform.Find("Text").gameObject.SetActive(true);
    }

    void Hide()
    {
        combination.image.enabled = false;
        combination.transform.Find("Placeholder").gameObject.SetActive(false);
        combination.transform.Find("Text").gameObject.SetActive(false);
    }
}
