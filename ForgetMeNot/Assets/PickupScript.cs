using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public Healthbar hb;
    public GameObject pl;
    AudioSource healthAudio;
    AudioSource shieldAudio;
    float addH;

    void Start()
    {
        healthAudio = GameObject.Find("GameObject health").GetComponent<AudioSource>();
        shieldAudio = GameObject.Find("GameObject shield").GetComponent<AudioSource>();
        addH = hb.slider.value;
    }

    void OnMouseDown()
    {
        
        if (gameObject.tag == "HealthPU") //health is below 100
        {
            gameObject.SetActive(false);
            healthAudio.Play();
            AddHealth(10f);
            
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
            AddHealth(10f);
        }
        
        if (gameObject.tag == "ShieldPU")
        {
            gameObject.SetActive(false);
            shieldAudio.Play();
        }
    }

    void AddHealth(float health) 
    {
        addH += health;
        hb.SetHealth(addH);
    }

}
