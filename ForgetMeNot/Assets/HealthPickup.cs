using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public Healthbar hb;
    public Manager man;
    AudioSource healthAudio;

    void Start()
    {
        healthAudio = GameObject.Find("GameObject health").GetComponent<AudioSource>();   
    }

    void OnMouseDown()
    {
        healthAudio.Play();
        
        if (gameObject.tag == "HealthPU") //health is below 100
        {
            gameObject.SetActive(false);
            //addHealth();
        }
        
    }

    void OnTriggerEnter(Collider coll)
    {
        if (gameObject.tag == "HealthPU")
        {
            gameObject.SetActive(false);
            //addHealth();
        }
    }

    // Update is called once per frame
    void addHealth()
    {
        //man.currentHealth += 10;
        //hb.SetHealth(man.currentHealth);
    }
}
