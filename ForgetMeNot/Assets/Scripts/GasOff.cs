using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasOff : MonoBehaviour
{
    public GameObject player;
    private playerController playerCScript;
    private PressButton buttonPressor;
    // Start is called before the first frame update
    void Start()
    {
        playerCScript = player.GetComponent<playerController>();
        buttonPressor = gameObject.GetComponent<PressButton>();
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonPressor.isPressed)
        {
            playerCScript.gasOn = false;
            GameManager.instance.gasOn = false;
            SaveManager.instance.activeSave.gasOn = false;
            SaveManager.instance.Save();
        }
    }
}
