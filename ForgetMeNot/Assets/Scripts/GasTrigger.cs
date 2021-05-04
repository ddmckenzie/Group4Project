using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasTrigger : MonoBehaviour
{
    public GameObject player;
    private playerController playerCScript;

    // Start is called before the first frame update
    void Start()
    {
        playerCScript = player.GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        playerCScript.gasOn = true;
        GameManager.instance.gasOn = true;
        SaveManager.instance.activeSave.gasOn = true;
        SaveManager.instance.Save();
    }
}
