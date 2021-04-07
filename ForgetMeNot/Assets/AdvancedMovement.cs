using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedMovement : MonoBehaviour
{
    // Start is called before the first frame update
    playerMovement basicMovement;
    public float speedBoost = 7f;

    void Start()
    {
        basicMovement = GetComponent<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            basicMovement.speed += speedBoost;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift)) 
        {
            basicMovement.speed -= speedBoost;
        }
    }
}
