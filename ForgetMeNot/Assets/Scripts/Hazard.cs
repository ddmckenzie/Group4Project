using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public float damage;
    public GameObject player;
    AudioSource heatAudio;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        heatAudio = GameObject.Find("GameObject heat panel").GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider coll)
    {

            heatAudio.Play();


        if (gameObject.tag == "Hallway") 
        {
            heatAudio.Stop();
        }
    }
    // Update is called once per frame
    void Update()
    {
        //If Player Collider touches damage collider, player takes damage

    }
}
