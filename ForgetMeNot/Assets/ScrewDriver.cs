using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewDriver : MonoBehaviour
{
    public Manager manager;

    void OnMouseDown() {
        manager.foundScrewDriver();
    }
}
