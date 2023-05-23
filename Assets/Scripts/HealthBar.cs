using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetHp(int health)
    {
        slider.value = health;
    }

    public void SetMaxHp(int maxHP)
    {
        slider.maxValue = maxHP;
    }
}
