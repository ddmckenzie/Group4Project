using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    Vector3 StartPos;
    public bool isPressed;
    int count;
    public GameObject player;
    private playerController playerCScript;
    // Start is called before the first frame update
    void Start()
    {
        playerCScript = player.GetComponent<playerController>();
        StartPos = transform.position;
        isPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        StartCoroutine("Press");

        if (!SaveManager.instance.activeSave.unlockedDoors.Contains(4) || !SaveManager.instance.activeSave.unlockedDoors.Contains(5))
        {
            GameManager.instance.unlockedDoors.Add(4); // 4 is index for storage door
            GameManager.instance.unlockedDoors.Add(5); // 5 is index for exit door
            SaveManager.instance.activeSave.unlockedDoors.Add(4);
            SaveManager.instance.activeSave.unlockedDoors.Add(5);
            SaveManager.instance.Save();

            Debug.Log("Unlocking Storage and Exit");
        }
    }

    private IEnumerator Press()
    {
        if (!isPressed)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.05f, transform.localPosition.z);
            playerCScript.gasOn = false;
        }
        isPressed = true;
        yield return new WaitForSeconds(0f);
    }
}
