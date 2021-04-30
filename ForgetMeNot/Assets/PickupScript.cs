using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public Healthbar hb;
    public GameObject player;
    AudioSource healthAudio;
    AudioSource shieldAudio;
    private playerController _playerCScript;

    void Start()
    {
        healthAudio = GameObject.Find("GameObject health").GetComponent<AudioSource>();
        shieldAudio = GameObject.Find("GameObject shield").GetComponent<AudioSource>();
        _playerCScript = player.GetComponent<playerController>();
    }

    void OnMouseDown()
    {
        
        if (gameObject.tag == "HealthPU") //health is below 100
        {
            gameObject.SetActive(false);
            healthAudio.Play();
            _playerCScript.AddHealth(10f);
        }
        
        if (gameObject.tag == "ShieldPU") 
        {
            gameObject.SetActive(false);
            shieldAudio.Play();
            _playerCScript.AddArmor(25f);
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (gameObject.tag == "HealthPU")
        {
            gameObject.SetActive(false);
            healthAudio.Play();
            _playerCScript.AddHealth(10f);
        }
        
        if (gameObject.tag == "ShieldPU")
        {
            gameObject.SetActive(false);
            shieldAudio.Play();
            _playerCScript.AddArmor(25f);
        }
    }

    //void AddHealth(float health) 
    //{
        //addH += health;
        //hb.SetHealth(addH);
    //}

}
