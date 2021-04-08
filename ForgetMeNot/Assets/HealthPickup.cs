using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public Healthbar hb;
    public Manager man;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        if (gameObject.tag == "HealthPU") 
        {
            gameObject.SetActive(false);
            addHealth();
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (gameObject.tag == "HealthPU")
        {
            gameObject.SetActive(false);
            addHealth();
        }
    }

    // Update is called once per frame
    void addHealth()
    {
        man.currentHealth += 10;
        hb.SetHealth(man.currentHealth);
    }
}
