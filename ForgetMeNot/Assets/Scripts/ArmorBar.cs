using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script based of tuturial by Brackeys
public class ArmorBar : MonoBehaviour
{
    //public Manager manager;
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    void Start()
    {
        //SetMaxHealth(manager.maxHealth);
        //SetHealth(manager.currentHealth);
    }

    public void SetMaxArmor(float armor)
    {
        slider.maxValue = armor;
        slider.value = armor;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetArmor(float armor)
    {
        slider.value = armor;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
