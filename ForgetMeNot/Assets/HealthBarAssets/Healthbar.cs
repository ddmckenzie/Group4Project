using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script based of tuturial by Brackeys
public class Healthbar : MonoBehaviour
{
    public Manager manager;
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    void Start()
    {
        SetMaxHealth(manager.maxHealth);
        SetHealth(manager.currentHealth);
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
