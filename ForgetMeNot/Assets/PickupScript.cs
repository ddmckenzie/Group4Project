using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public Healthbar hb;
    public Manager man;
    AudioSource healthAudio;
    AudioSource shieldAudio;

    void Start()
    {
        healthAudio = GameObject.Find("GameObject health").GetComponent<AudioSource>();
        shieldAudio = GameObject.Find("GameObject shield").GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        
        if (gameObject.tag == "HealthPU") //health is below 100
        {
            gameObject.SetActive(false);
            healthAudio.Play();
            //addHealth();
        }
        if (gameObject.tag == "ShieldPU") 
        {
            gameObject.SetActive(false);
            shieldAudio.Play();
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (gameObject.tag == "HealthPU")
        {
            gameObject.SetActive(false);
            healthAudio.Play();
            //addHealth();
        }
        
        if (gameObject.tag == "ShieldPU")
        {
            gameObject.SetActive(false);
            shieldAudio.Play();
        }
    }

    // Update is called once per frame
    void addHealth()
    {
        //man.currentHealth += 10;
        //hb.SetHealth(man.currentHealth);
    }
}
